using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace EduManage.Modules.Inventory
{
    public class DocumentGenerator
    {
        public void SaveToDocx<T>(string filePath, string title, string description, IEnumerable<T> data)
        {
            try
            {
                using (WordprocessingDocument wordDocument =
                    WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    AddOrganizationHeader(body);

                    AddDocumentTitle(body, title);

                    AddDocumentDescription(body, description);

                    AddDataTable(body, data);

                    AddDocumentDate(body);

                    mainPart.Document.Save();
                }

                MessageBox.Show($"Документ успешно сохранен:\n{filePath}", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении документа:\n{ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddOrganizationHeader(Body body)
        {
            Paragraph orgParagraph = body.AppendChild(new Paragraph());
            Run orgRun = orgParagraph.AppendChild(new Run());
            orgRun.AppendChild(new Text("ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ"));

            RunProperties orgProperties = orgRun.AppendChild(new RunProperties());
            orgProperties.AppendChild(new Bold());
            orgProperties.AppendChild(new FontSize() { Val = "22" });
            orgProperties.AppendChild(new RunFonts() { Ascii = "Times New Roman" });
            orgProperties.AppendChild(new Color() { Val = "2F5496" });

            orgParagraph.ParagraphProperties = new ParagraphProperties(
                new Justification() { Val = JustificationValues.Center },
                new SpacingBetweenLines() { After = "100" }
            );
        }

        private void AddDocumentTitle(Body body, string title)
        {
            Paragraph titleParagraph = body.AppendChild(new Paragraph());
            Run titleRun = titleParagraph.AppendChild(new Run());
            titleRun.AppendChild(new Text(title.ToUpper()));

            RunProperties titleProperties = titleRun.AppendChild(new RunProperties());
            titleProperties.AppendChild(new Bold());
            titleProperties.AppendChild(new FontSize() { Val = "28" });
            titleProperties.AppendChild(new RunFonts() { Ascii = "Times New Roman" });
            titleProperties.AppendChild(new Color() { Val = "1F3864" });

            titleParagraph.ParagraphProperties = new ParagraphProperties(
                new Justification() { Val = JustificationValues.Center },
                new SpacingBetweenLines() { After = "200" },
                new Shading() { Fill = "D9E2F3" }
            );
        }

        private void AddDocumentDescription(Body body, string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return;

            Paragraph descParagraph = body.AppendChild(new Paragraph());
            Run descRun = descParagraph.AppendChild(new Run());
            descRun.AppendChild(new Text(description));

            RunProperties descProperties = descRun.AppendChild(new RunProperties());
            descProperties.AppendChild(new Italic());
            descProperties.AppendChild(new FontSize() { Val = "20" });
            descProperties.AppendChild(new RunFonts() { Ascii = "Times New Roman" });

            descParagraph.ParagraphProperties = new ParagraphProperties(
                new Justification() { Val = JustificationValues.Both },
                new SpacingBetweenLines() { Before = "200", After = "200" },
                new Indentation() { FirstLine = "567" }
            );
        }

        private void AddDataTable<T>(Body body, IEnumerable<T> data)
        {
            if (data == null || !data.Any())
                return;

            Table table = new Table();

            TableProperties tableProperties = new TableProperties(
                new TableBorders(
                    new TopBorder() { Val = BorderValues.Single, Size = 8, Color = "1F3864" },
                    new BottomBorder() { Val = BorderValues.Single, Size = 8, Color = "1F3864" },
                    new LeftBorder() { Val = BorderValues.Single, Size = 8, Color = "1F3864" },
                    new RightBorder() { Val = BorderValues.Single, Size = 8, Color = "1F3864" },
                    new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 4, Color = "1F3864" },
                    new InsideVerticalBorder() { Val = BorderValues.Single, Size = 4, Color = "1F3864" }
                ),
                new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct },
                new TableLayout() { Type = TableLayoutValues.Fixed },
                new TableLook() { Val = "04A0" }
            );
            table.AppendChild(tableProperties);

            var properties = typeof(T).GetProperties();

            TableRow headerRow = new TableRow();

            foreach (var prop in properties)
            {
                var displayNameAttr = prop.GetCustomAttributes(typeof(DisplayNameAttribute), false)
                                    .FirstOrDefault() as DisplayNameAttribute;
                string columnName = displayNameAttr?.DisplayName ?? prop.Name;

                TableCell cell = new TableCell(new Paragraph(new Run(new Text(columnName))));

                cell.TableCellProperties = new TableCellProperties(
                    new Shading() { Fill = "D9E2F3" },
                    new TableCellWidth() { Width = "2000", Type = TableWidthUnitValues.Dxa },
                    new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
                );

                RunProperties runProperties = new RunProperties(
                    new Bold(),
                    new RunFonts() { Ascii = "Times New Roman" },
                    new Color() { Val = "1F3864" },
                    new FontSize() { Val = "20" }
                );

                cell.Elements<Paragraph>().First().InsertAt(runProperties, 0);
                cell.Elements<Paragraph>().First().ParagraphProperties = new ParagraphProperties(
                    new Justification() { Val = JustificationValues.Center }
                );

                headerRow.AppendChild(cell);
            }

            table.AppendChild(headerRow);

            foreach (var item in data)
            {
                TableRow row = new TableRow();

                foreach (var prop in properties)
                {
                    object value = prop.GetValue(item);
                    string text = value?.ToString() ?? string.Empty;

                    TableCell cell = new TableCell(new Paragraph(new Run(new Text(text))));
                    cell.TableCellProperties = new TableCellProperties(
                        new TableCellWidth() { Width = "2000", Type = TableWidthUnitValues.Dxa },
                        new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
                    );

                    RunProperties cellProperties = new RunProperties(
                        new RunFonts() { Ascii = "Times New Roman" },
                        new FontSize() { Val = "18" }
                    );

                    cell.Elements<Paragraph>().First().InsertAt(cellProperties, 0);
                    cell.Elements<Paragraph>().First().ParagraphProperties = new ParagraphProperties(
                        new Justification() { Val = JustificationValues.Center }
                    );

                    row.AppendChild(cell);
                }

                table.AppendChild(row);
            }

            body.AppendChild(table);
        }

        private void AddDocumentDate(Body body)
        {
            Paragraph dateParagraph = body.AppendChild(new Paragraph());
            Run dateRun = dateParagraph.AppendChild(new Run());
            dateRun.AppendChild(new Text($"Дата формирования: {DateTime.Now:dd.MM.yyyy}"));

            RunProperties dateProperties = dateRun.AppendChild(new RunProperties());
            dateProperties.AppendChild(new Italic());
            dateProperties.AppendChild(new FontSize() { Val = "18" });
            dateProperties.AppendChild(new RunFonts() { Ascii = "Times New Roman" });

            dateParagraph.ParagraphProperties = new ParagraphProperties(
                new Justification() { Val = JustificationValues.Right },
                new SpacingBetweenLines() { Before = "400" }
            );
        }

    }
}