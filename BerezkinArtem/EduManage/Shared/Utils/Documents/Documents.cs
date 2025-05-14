using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

public enum DocumentTemplateType
{
    DefectReport,    // Дефектная ведомость
    PartsInstallationAct, // Акт установки запасных частей
    ExpenseEstimate, // Смета расходов
    GeneralInventory // Общий инвентарный документ
}

public class DocumentGenerator
{
    public void SaveToDocx<T>(string filePath, DocumentTemplateType templateType,
                            string title, string description, IEnumerable<T> data,
                            Dictionary<string, string> additionalFields = null)
    {
        try
        {
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                switch (templateType)
                {
                    case DocumentTemplateType.DefectReport:
                        GenerateDefectReport(body, title, data, additionalFields);
                        break;
                    case DocumentTemplateType.PartsInstallationAct:
                        GeneratePartsInstallationAct(body, title, data, additionalFields);
                        break;
                    case DocumentTemplateType.ExpenseEstimate:
                        GenerateExpenseEstimate(body, title, data, additionalFields);
                        break;
                    default:
                        GenerateGeneralDocument(body, title, description, data);
                        break;
                }

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

    private void GenerateDefectReport<T>(Body body, string title, IEnumerable<T> data,
                                       Dictionary<string, string> additionalFields)
    {
        // Шапка документа
        AddOrganizationHeader(body, "МБОУ СОШ № 9");
        AddDocumentTitle(body, "ДЕФЕКТНАЯ ВЕДОМОСТЬ");

        // Состав комиссии
        Paragraph commissionParagraph = body.AppendChild(new Paragraph());
        Run commissionRun = commissionParagraph.AppendChild(new Run());
        commissionRun.AppendChild(new Text("Мы комиссия в составе Председателя комиссии ______ члены комиссии:"));

        // Добавляем строки для подписей членов комиссии
        for (int i = 0; i < 4; i++)
        {
            body.AppendChild(new Paragraph(new Run(new Text("______"))));
        }

        // Информация об автобусе
        if (additionalFields != null)
        {
            body.AppendChild(new Paragraph(new Run(new Text(
                $"Осмотрев автобус {additionalFields.GetValueOrDefault("BusModel", "______")} " +
                $"гос номер {additionalFields.GetValueOrDefault("LicensePlate", "______")} " +
                "были обнаружены дефекты запасных частей"))));
        }

        // Таблица дефектов
        Table table = new Table();
        TableProperties tableProperties = new TableProperties(
            new TableBorders(
                new TopBorder() { Val = BorderValues.Single, Size = 4 },
                new BottomBorder() { Val = BorderValues.Single, Size = 4 },
                new LeftBorder() { Val = BorderValues.Single, Size = 4 },
                new RightBorder() { Val = BorderValues.Single, Size = 4 },
                new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 2 },
                new InsideVerticalBorder() { Val = BorderValues.Single, Size = 2 }
            ),
            new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct }
        );
        table.AppendChild(tableProperties);

        // Заголовки таблицы
        TableRow headerRow = new TableRow();
        string[] headers = { "№ п/п", "Наименование запасных частей", "Ед.изм.", "Количество", "Причина" };

        foreach (var header in headers)
        {
            TableCell cell = new TableCell(new Paragraph(new Run(new Text(header))));
            cell.TableCellProperties = new TableCellProperties(
                new Shading() { Fill = "D9E2F3" },
                new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
            );
            headerRow.AppendChild(cell);
        }
        table.AppendChild(headerRow);

        // Добавление данных
        if (data != null)
        {
            int rowNum = 1;
            foreach (var item in data)
            {
                TableRow row = new TableRow();

                // № п/п
                row.AppendChild(CreateTableCell(rowNum.ToString()));
                rowNum++;

                // Остальные ячейки заполняются данными
                var properties = typeof(T).GetProperties();
                for (int i = 0; i < 4; i++) // 4 колонки данных
                {
                    var prop = properties[i];
                    object value = prop.GetValue(item);
                    row.AppendChild(CreateTableCell(value?.ToString() ?? ""));
                }

                table.AppendChild(row);
            }
        }

        body.AppendChild(table);

        // Заключение и подписи
        body.AppendChild(new Paragraph(new Run(new Text(
            "Заключение: Для устранения выявленных дефектов необходима замена запасных частей."))));

        AddSignatures(body, "Председатель комиссии", 4);
    }

    private void GeneratePartsInstallationAct<T>(Body body, string title, IEnumerable<T> data,
                                              Dictionary<string, string> additionalFields)
    {
        // Шапка документа
        AddOrganizationHeader(body, "МБОУ СОШ № 9");
        AddDocumentTitle(body, "АКТ УСТАНОВКИ ЗАПАСНЫХ ЧАСТЕЙ");

        // Информация об автобусе
        if (additionalFields != null)
        {
            body.AppendChild(new Paragraph(new Run(new Text(
                $"Автобус {additionalFields.GetValueOrDefault("BusModel", "______")} " +
                $"регистр. знак {additionalFields.GetValueOrDefault("LicensePlate", "______")}"))));

            body.AppendChild(new Paragraph(new Run(new Text(
                $"Показание спидометра {additionalFields.GetValueOrDefault("Mileage", "______")} " +
                $"от «__» ______ 20__ года."))));
        }

        // Состав комиссии
        body.AppendChild(new Paragraph(new Run(new Text("Комиссия в составе:"))));
        body.AppendChild(new Paragraph(new Run(new Text("Председатель комиссии ______"))));
        for (int i = 1; i <= 3; i++)
        {
            body.AppendChild(new Paragraph(new Run(new Text($"{i}. ______"))));
        }

        body.AppendChild(new Paragraph(new Run(new Text(
            "Составили настоящий акт о том, что приобретенные запасные части установлены на автобус."))));

        // Таблица установленных частей
        Table table = new Table();
        TableProperties tableProperties = new TableProperties(
            new TableBorders(
                new TopBorder() { Val = BorderValues.Single, Size = 4 },
                new BottomBorder() { Val = BorderValues.Single, Size = 4 },
                new LeftBorder() { Val = BorderValues.Single, Size = 4 },
                new RightBorder() { Val = BorderValues.Single, Size = 4 },
                new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 2 },
                new InsideVerticalBorder() { Val = BorderValues.Single, Size = 2 }
            ),
            new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct }
        );
        table.AppendChild(tableProperties);

        // Заголовки таблицы
        TableRow headerRow = new TableRow();
        string[] headers = { "№ п/п", "Наименование запасных частей", "Цена", "Примечание" };

        foreach (var header in headers)
        {
            TableCell cell = new TableCell(new Paragraph(new Run(new Text(header))));
            cell.TableCellProperties = new TableCellProperties(
                new Shading() { Fill = "D9E2F3" },
                new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
            );
            headerRow.AppendChild(cell);
        }
        table.AppendChild(headerRow);

        // Добавление данных
        if (data != null)
        {
            int rowNum = 1;
            foreach (var item in data)
            {
                TableRow row = new TableRow();

                // № п/п
                row.AppendChild(CreateTableCell(rowNum.ToString()));
                rowNum++;

                // Остальные ячейки заполняются данными
                var properties = typeof(T).GetProperties();
                for (int i = 0; i < 3; i++) // 3 колонки данных
                {
                    var prop = properties[i];
                    object value = prop.GetValue(item);
                    row.AppendChild(CreateTableCell(value?.ToString() ?? ""));
                }

                table.AppendChild(row);
            }
        }

        body.AppendChild(table);

        // Подписи
        AddSignatures(body, "Председатель комиссии", 3);
        body.AppendChild(new Paragraph(new Run(new Text("Водитель ______ (подпись) (фамилия)"))));
    }

    private void GenerateExpenseEstimate<T>(Body body, string title, IEnumerable<T> data,
                                          Dictionary<string, string> additionalFields)
    {
        // Шапка документа
        AddOrganizationHeader(body, "МБОУ СОШ № 9");
        body.AppendChild(new Paragraph(new Run(new Text("Утверждаю"))));
        body.AppendChild(new Paragraph(new Run(new Text("Директор МБОУ СОШ № 9"))));
        body.AppendChild(new Paragraph(new Run(new Text("______ Мамишев Р.А."))));
        body.AppendChild(new Paragraph(new Run(new Text("\"______\"______ 20__г."))));

        AddDocumentTitle(body, "СМЕТА РАСХОДОВ");

        // Состав комиссии
        body.AppendChild(new Paragraph(new Run(new Text("Комиссия в составе:"))));
        body.AppendChild(new Paragraph(new Run(new Text("Председателя комиссии – Пилипенко И.С. - заведующей библиотекой"))));
        body.AppendChild(new Paragraph(new Run(new Text("Членов комиссии:"))));
        body.AppendChild(new Paragraph(new Run(new Text("Вороковой Н.А. – председателя профкома"))));
        body.AppendChild(new Paragraph(new Run(new Text("Середа И.М. – учителя информатики"))));

        // Таблица расходов
        Table table = new Table();
        TableProperties tableProperties = new TableProperties(
            new TableBorders(
                new TopBorder() { Val = BorderValues.Single, Size = 4 },
                new BottomBorder() { Val = BorderValues.Single, Size = 4 },
                new LeftBorder() { Val = BorderValues.Single, Size = 4 },
                new RightBorder() { Val = BorderValues.Single, Size = 4 },
                new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 2 },
                new InsideVerticalBorder() { Val = BorderValues.Single, Size = 2 }
            ),
            new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct }
        );
        table.AppendChild(tableProperties);

        // Заголовки таблицы
        TableRow headerRow = new TableRow();
        string[] headers = { "№ п/п", "Наименование расходов", "Количество", "Цена", "Сумма" };

        foreach (var header in headers)
        {
            TableCell cell = new TableCell(new Paragraph(new Run(new Text(header))));
            cell.TableCellProperties = new TableCellProperties(
                new Shading() { Fill = "D9E2F3" },
                new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
            );
            headerRow.AppendChild(cell);
        }
        table.AppendChild(headerRow);

        // Добавление данных
        if (data != null)
        {
            int rowNum = 1;
            foreach (var item in data)
            {
                TableRow row = new TableRow();

                // № п/п
                row.AppendChild(CreateTableCell(rowNum.ToString()));
                rowNum++;

                // Остальные ячейки заполняются данными
                var properties = typeof(T).GetProperties();
                for (int i = 0; i < 4; i++) // 4 колонки данных
                {
                    var prop = properties[i];
                    object value = prop.GetValue(item);
                    row.AppendChild(CreateTableCell(value?.ToString() ?? ""));
                }

                table.AppendChild(row);
            }
        }

        body.AppendChild(table);

        // Подписи
        body.AppendChild(new Paragraph(new Run(new Text("Председатель комиссии – зав. библиотекой ______"))));
        body.AppendChild(new Paragraph(new Run(new Text("Члены комиссии:"))));
        body.AppendChild(new Paragraph(new Run(new Text("председатель профкома ______"))));
        body.AppendChild(new Paragraph(new Run(new Text("учитель информатики ______"))));
        body.AppendChild(new Paragraph(new Run(new Text("Смету составил зам.директора по АХЧ ______"))));
    }

    private void GenerateGeneralDocument<T>(Body body, string title, string description, IEnumerable<T> data)
    {
        // Общая реализация для других типов документов
        AddOrganizationHeader(body, "ОБРАЗОВАТЕЛЬНОЕ УЧРЕЖДЕНИЕ");
        AddDocumentTitle(body, title);
        AddDocumentDescription(body, description);
        AddDataTable(body, data);
        AddDocumentDate(body);
    }

    private void AddOrganizationHeader(Body body, string organizationName)
    {
        Paragraph orgParagraph = body.AppendChild(new Paragraph());
        Run orgRun = orgParagraph.AppendChild(new Run());
        orgRun.AppendChild(new Text(organizationName));

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

    private TableCell CreateTableCell(string text)
    {
        TableCell cell = new TableCell(new Paragraph(new Run(new Text(text))));
        cell.TableCellProperties = new TableCellProperties(
            new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
        );
        return cell;
    }

    private void AddSignatures(Body body, string title, int count)
    {
        body.AppendChild(new Paragraph(new Run(new Text($"{title} ______ ______"))));
        body.AppendChild(new Paragraph(new Run(new Text("(подпись) (фамилия)"))));

        body.AppendChild(new Paragraph(new Run(new Text("Члены комиссии:"))));

        for (int i = 1; i <= count; i++)
        {
            body.AppendChild(new Paragraph(new Run(new Text($"{i}. ______ ______"))));
            body.AppendChild(new Paragraph(new Run(new Text("(подписи) (фамилии)"))));
        }
    }
}