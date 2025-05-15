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

public class Documents
{
    public void SaveToDocx<T>(string filePath, DocumentTemplateType templateType,
                            string title, IEnumerable<T> data,
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

                AddStandardHeader(body, additionalFields);

                switch (templateType)
                {
                    case DocumentTemplateType.DefectReport:
                        GenerateDefectReport(body, data, additionalFields);
                        break;
                    case DocumentTemplateType.PartsInstallationAct:
                        GeneratePartsInstallationAct(body, data, additionalFields);
                        break;
                    case DocumentTemplateType.ExpenseEstimate:
                        GenerateExpenseEstimate(body, data, additionalFields);
                        break;
                    default:
                        GenerateGeneralDocument(body, title, data);
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

    private void AddStandardHeader(Body body, Dictionary<string, string> additionalFields)
    {
        Paragraph directorParagraph = body.AppendChild(new Paragraph());
        Run directorRun = directorParagraph.AppendChild(new Run());
        directorRun.AppendChild(new Text("Директор МБОУ СОШ № 9"));

        Paragraph nameParagraph = body.AppendChild(new Paragraph());
        Run nameRun = nameParagraph.AppendChild(new Run());
        nameRun.AppendChild(new Text("Р.А.Мамишев ____________"));

        Paragraph dateParagraph = body.AppendChild(new Paragraph());
        Run dateRun = dateParagraph.AppendChild(new Run());
        dateRun.AppendChild(new Text($"«___» ______ {DateTime.Now.Year} г."));

        RunProperties headerProperties = new RunProperties(
            new RunFonts() { Ascii = "Times New Roman" },
            new FontSize() { Val = "22" }
        );

        directorRun.PrependChild(new RunProperties(headerProperties.CloneNode(true)));
        nameRun.PrependChild(new RunProperties(headerProperties.CloneNode(true)));
        dateRun.PrependChild(new RunProperties(headerProperties.CloneNode(true)));

        // Выравнивание по правому краю
        directorParagraph.ParagraphProperties = new ParagraphProperties(
            new Justification() { Val = JustificationValues.Right }
        );
        nameParagraph.ParagraphProperties = new ParagraphProperties(
            new Justification() { Val = JustificationValues.Right }
        );
        dateParagraph.ParagraphProperties = new ParagraphProperties(
            new Justification() { Val = JustificationValues.Right }
        );
    }

    private void GenerateDefectReport<T>(Body body, IEnumerable<T> data, Dictionary<string, string> additionalFields)
    {
        // Название документа
        AddDocumentTitle(body, "ДЕФЕКТНАЯ ВЕДОМОСТЬ");

        // Состав комиссии
        Paragraph commissionParagraph = body.AppendChild(new Paragraph());
        Run commissionRun = commissionParagraph.AppendChild(new Run());
        commissionRun.AppendChild(new Text("Мы комиссия в составе:"));

        Paragraph chairmanParagraph = body.AppendChild(new Paragraph());
        Run chairmanRun = chairmanParagraph.AppendChild(new Run());
        chairmanRun.AppendChild(new Text("Председатель комиссии: ______"));

        Paragraph membersParagraph = body.AppendChild(new Paragraph());
        Run membersRun = membersParagraph.AppendChild(new Run());
        membersRun.AppendChild(new Text("Члены комиссии:"));

        // Три члена комиссии с нумерацией
        for (int i = 1; i <= 3; i++)
        {
            Paragraph memberParagraph = body.AppendChild(new Paragraph());
            Run memberRun = memberParagraph.AppendChild(new Run());
            memberRun.AppendChild(new Text($"{i}. _________________________________________"));
        }

        Paragraph driverParagraph = body.AppendChild(new Paragraph());
        Run driverRun = driverParagraph.AppendChild(new Run());
        driverRun.AppendChild(new Text("В присутствии водителя: ______"));

        // Пустая строка
        body.AppendChild(new Paragraph(new Run(new Text(""))));

        // Информация об автобусе
        string busModel = additionalFields != null && additionalFields.ContainsKey("BusModel")
            ? additionalFields["BusModel"]
            : "______";

        string licensePlate = additionalFields != null && additionalFields.ContainsKey("LicensePlate")
            ? additionalFields["LicensePlate"]
            : "______";

        Paragraph busParagraph = body.AppendChild(new Paragraph());
        Run busRun = busParagraph.AppendChild(new Run());
        busRun.AppendChild(new Text($"Осмотрев автобус {busModel} гос. номер {licensePlate}, были обнаружены дефекты запасных частей:"));

        // Пустая строка перед таблицей
        body.AppendChild(new Paragraph(new Run(new Text(""))));

        // Таблица дефектов (23 строки)
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
                new Shading() { Fill = "D9D9D9" },
                new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
            );
            headerRow.AppendChild(cell);
        }
        table.AppendChild(headerRow);

        // Заполнение данных
        int rowNumber = 1;
        foreach (var item in data.Take(23)) // Ограничение 23 строки как в образце
        {
            TableRow row = new TableRow();

            // Номер строки
            row.AppendChild(CreateTableCell(rowNumber.ToString(), center: true));
            rowNumber++;

            // Остальные данные
            var props = typeof(T).GetProperties();
            for (int i = 0; i < 4; i++) // 4 столбца данных
            {
                string value = props[i].GetValue(item)?.ToString() ?? "";
                row.AppendChild(CreateTableCell(value, center: true));
            }

            table.AppendChild(row);
        }

        // Добавляем пустые строки, если данных меньше 23
        for (int i = rowNumber; i <= 23; i++)
        {
            TableRow emptyRow = new TableRow();
            emptyRow.AppendChild(CreateTableCell(i.ToString(), center: true));
            for (int j = 0; j < 4; j++)
            {
                emptyRow.AppendChild(CreateTableCell("", center: true));
            }
            table.AppendChild(emptyRow);
        }

        body.AppendChild(table);

        // Заключение
        Paragraph conclusionParagraph = body.AppendChild(new Paragraph());
        Run conclusionRun = conclusionParagraph.AppendChild(new Run());
        conclusionRun.AppendChild(new Text("Заключение: Для устранения выявленных дефектов необходима замена запасных частей."));

        // Подписи (4 члена комиссии как в образце)
        AddStandardSignatures(body, 4);
    }

    private void GeneratePartsInstallationAct<T>(Body body, IEnumerable<T> data, Dictionary<string, string> additionalFields)
    {
        // Название документа
        AddDocumentTitle(body, "АКТ УСТАНОВКИ ЗАПАСНЫХ ЧАСТЕЙ");

        // Информация об автобусе
        string busModel = (additionalFields != null && additionalFields.ContainsKey("BusModel")) ? additionalFields["BusModel"] : "______";
        string licensePlate = (additionalFields != null && additionalFields.ContainsKey("LicensePlate")) ? additionalFields["LicensePlate"] : "______";
        string mileage = (additionalFields != null && additionalFields.ContainsKey("Mileage")) ? additionalFields["Mileage"] : "______";

        Paragraph busParagraph = body.AppendChild(new Paragraph());
        Run busRun = busParagraph.AppendChild(new Run());
        busRun.AppendChild(new Text($"Автобус: {busModel}"));

        Paragraph plateParagraph = body.AppendChild(new Paragraph());
        Run plateRun = plateParagraph.AppendChild(new Run());
        plateRun.AppendChild(new Text($"Регистрационный знак: {licensePlate}"));

        Paragraph mileageParagraph = body.AppendChild(new Paragraph());
        Run mileageRun = mileageParagraph.AppendChild(new Run());
        mileageRun.AppendChild(new Text($"Показание спидометра: {mileage} от «___» ______ {DateTime.Now.Year} г."));

        // Состав комиссии
        Paragraph commissionParagraph = body.AppendChild(new Paragraph());
        Run commissionRun = commissionParagraph.AppendChild(new Run());
        commissionRun.AppendChild(new Text("Комиссия в составе:"));

        Paragraph chairmanParagraph = body.AppendChild(new Paragraph());
        Run chairmanRun = chairmanParagraph.AppendChild(new Run());
        chairmanRun.AppendChild(new Text("Председатель комиссии: ______"));

        for (int i = 0; i < 3; i++)
        {
            body.AppendChild(new Paragraph(new Run(new Text($"Член комиссии {i + 1}: ______"))));
        }

        Paragraph actParagraph = body.AppendChild(new Paragraph());
        Run actRun = actParagraph.AppendChild(new Run());
        actRun.AppendChild(new Text("Составили настоящий акт о том, что приобретенные запасные части установлены на автобус:"));

        // Таблица установленных частей
        CreateTable(body, data, new[] { "№ п/п", "Наименование запасных частей", "Цена", "Примечание" });

        // Подписи
        AddStandardSignatures(body, 3);

        Paragraph driverParagraph = body.AppendChild(new Paragraph());
        Run driverRun = driverParagraph.AppendChild(new Run());
        driverRun.AppendChild(new Text("Водитель: ______ (подпись) (Ф.И.О.)"));
    }

    private void GenerateExpenseEstimate<T>(Body body, IEnumerable<T> data, Dictionary<string, string> additionalFields)
    {
        // Название документа
        AddDocumentTitle(body, "СМЕТА РАСХОДОВ");

        // Состав комиссии
        Paragraph commissionParagraph = body.AppendChild(new Paragraph());
        Run commissionRun = commissionParagraph.AppendChild(new Run());
        commissionRun.AppendChild(new Text("Комиссия в составе:"));

        Paragraph chairmanParagraph = body.AppendChild(new Paragraph());
        Run chairmanRun = chairmanParagraph.AppendChild(new Run());
        chairmanRun.AppendChild(new Text("Председатель комиссии: Пилипенко И.С. - заведующая библиотекой"));

        Paragraph member1Paragraph = body.AppendChild(new Paragraph());
        Run member1Run = member1Paragraph.AppendChild(new Run());
        member1Run.AppendChild(new Text("Член комиссии: Ворокова Н.А. - председатель профкома"));

        Paragraph member2Paragraph = body.AppendChild(new Paragraph());
        Run member2Run = member2Paragraph.AppendChild(new Run());
        member2Run.AppendChild(new Text("Член комиссии: Середа И.М. - учитель информатики"));

        // Таблица расходов
        CreateTable(body, data, new[] { "№ п/п", "Наименование расходов", "Количество", "Цена", "Сумма" });

        // Подписи
        Paragraph sign1Paragraph = body.AppendChild(new Paragraph());
        Run sign1Run = sign1Paragraph.AppendChild(new Run());
        sign1Run.AppendChild(new Text("Председатель комиссии - зав. библиотекой: ______"));

        Paragraph sign2Paragraph = body.AppendChild(new Paragraph());
        Run sign2Run = sign2Paragraph.AppendChild(new Run());
        sign2Run.AppendChild(new Text("Члены комиссии:"));

        Paragraph sign3Paragraph = body.AppendChild(new Paragraph());
        Run sign3Run = sign3Paragraph.AppendChild(new Run());
        sign3Run.AppendChild(new Text("председатель профкома: ______"));

        Paragraph sign4Paragraph = body.AppendChild(new Paragraph());
        Run sign4Run = sign4Paragraph.AppendChild(new Run());
        sign4Run.AppendChild(new Text("учитель информатики: ______"));

        Paragraph sign5Paragraph = body.AppendChild(new Paragraph());
        Run sign5Run = sign5Paragraph.AppendChild(new Run());
        sign5Run.AppendChild(new Text("Смету составил зам.директора по АХЧ: ______"));
    }

    private void GenerateGeneralDocument<T>(Body body, string title, IEnumerable<T> data)
    {
        AddDocumentTitle(body, title);
        CreateTable(body, data);
        AddDocumentDate(body);
    }

    private void AddDocumentTitle(Body body, string title)
    {
        Paragraph titleParagraph = body.AppendChild(new Paragraph());
        Run titleRun = titleParagraph.AppendChild(new Run());
        titleRun.AppendChild(new Text(title));

        RunProperties titleProperties = new RunProperties(
            new Bold(),
            new RunFonts() { Ascii = "Times New Roman" },
            new FontSize() { Val = "24" },
            new Color() { Val = "000000" }
        );

        titleRun.PrependChild(titleProperties);

        titleParagraph.ParagraphProperties = new ParagraphProperties(
            new Justification() { Val = JustificationValues.Center },
            new SpacingBetweenLines() { After = "200" }
        );

        // Добавляем пустую строку после заголовка
        body.AppendChild(new Paragraph(new Run(new Text(""))));
    }

    private void CreateTable<T>(Body body, IEnumerable<T> data, string[] customHeaders = null)
    {
        if (data == null) return;

        Table table = new Table();

        // Настройки таблицы
        TableProperties tableProperties = new TableProperties(
            new TableBorders(
                new TopBorder() { Val = BorderValues.Single, Size = 4, Color = "000000" },
                new BottomBorder() { Val = BorderValues.Single, Size = 4, Color = "000000" },
                new LeftBorder() { Val = BorderValues.Single, Size = 4, Color = "000000" },
                new RightBorder() { Val = BorderValues.Single, Size = 4, Color = "000000" },
                new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 2, Color = "000000" },
                new InsideVerticalBorder() { Val = BorderValues.Single, Size = 2, Color = "000000" }
            ),
            new TableWidth() { Width = "100%", Type = TableWidthUnitValues.Pct },
            new TableLayout() { Type = TableLayoutValues.Fixed }
        );
        table.AppendChild(tableProperties);

        // Заголовки таблицы
        TableRow headerRow = new TableRow();
        var properties = typeof(T).GetProperties();
        string[] headers = customHeaders ?? properties.Select(p =>
        {
            var attr = p.GetCustomAttributes(typeof(DisplayNameAttribute), false)
                      .FirstOrDefault() as DisplayNameAttribute;
            return attr?.DisplayName ?? p.Name;
        }).ToArray();

        foreach (var header in headers)
        {
            TableCell cell = new TableCell(new Paragraph(new Run(new Text(header))));
            cell.TableCellProperties = new TableCellProperties(
                new Shading() { Fill = "D9D9D9" },
                new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
            );

            RunProperties runProperties = new RunProperties(
                new Bold(),
                new RunFonts() { Ascii = "Times New Roman" },
                new FontSize() { Val = "20" }
            );

            cell.Elements<Paragraph>().First().InsertAt(runProperties, 0);
            cell.Elements<Paragraph>().First().ParagraphProperties = new ParagraphProperties(
                new Justification() { Val = JustificationValues.Center }
            );

            headerRow.AppendChild(cell);
        }
        table.AppendChild(headerRow);

        // Данные таблицы
        int rowNum = 1;
        foreach (var item in data)
        {
            TableRow row = new TableRow();

            // Добавляем номер строки
            TableCell numberCell = new TableCell(new Paragraph(new Run(new Text(rowNum.ToString()))));
            numberCell.TableCellProperties = new TableCellProperties(
                new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
            );
            row.AppendChild(numberCell);

            // Остальные данные
            for (int i = 0; i < properties.Length && i < headers.Length - 1; i++)
            {
                var prop = properties[i];
                object value = prop.GetValue(item);
                string text = value?.ToString() ?? string.Empty;

                TableCell cell = new TableCell(new Paragraph(new Run(new Text(text))));
                cell.TableCellProperties = new TableCellProperties(
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
            rowNum++;
        }

        body.AppendChild(table);
    }

    private void AddStandardSignatures(Body body, int membersCount)
    {
        // Пустая строка перед подписями
        body.AppendChild(new Paragraph(new Run(new Text(""))));

        // Председатель
        Paragraph chairmanParagraph = body.AppendChild(new Paragraph());
        Run chairmanRun = chairmanParagraph.AppendChild(new Run());
        chairmanRun.AppendChild(new Text("Председатель комиссии: ______ ___________________________________"));

        Paragraph chairmanSignParagraph = body.AppendChild(new Paragraph());
        Run chairmanSignRun = chairmanSignParagraph.AppendChild(new Run());
        chairmanSignRun.AppendChild(new Text("(подпись) (Ф.И.О.)"));

        // Члены комиссии
        Paragraph membersParagraph = body.AppendChild(new Paragraph());
        Run membersRun = membersParagraph.AppendChild(new Run());
        membersRun.AppendChild(new Text("Члены комиссии:"));

        for (int i = 1; i <= membersCount; i++)
        {
            Paragraph memberParagraph = body.AppendChild(new Paragraph());
            Run memberRun = memberParagraph.AppendChild(new Run());
            memberRun.AppendChild(new Text($"{i}. ______ ___________________________________"));

            Paragraph memberSignParagraph = body.AppendChild(new Paragraph());
            Run memberSignRun = memberSignParagraph.AppendChild(new Run());
            memberSignRun.AppendChild(new Text("(подпись) (Ф.И.О.)"));
        }
    }

    private void AddDocumentDate(Body body)
    {
        Paragraph dateParagraph = body.AppendChild(new Paragraph());
        Run dateRun = dateParagraph.AppendChild(new Run());
        dateRun.AppendChild(new Text($"Дата составления: {DateTime.Now:dd.MM.yyyy}"));

        RunProperties dateProperties = new RunProperties(
            new RunFonts() { Ascii = "Times New Roman" },
            new FontSize() { Val = "18" }
        );

        dateRun.PrependChild(dateProperties);

        dateParagraph.ParagraphProperties = new ParagraphProperties(
            new Justification() { Val = JustificationValues.Right },
            new SpacingBetweenLines() { Before = "200" }
        );
    }
    private TableCell CreateTableCell(string text, bool center = false)
    {
        TableCell cell = new TableCell(new Paragraph(new Run(new Text(text))));
        cell.TableCellProperties = new TableCellProperties(
            new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center }
        );

        if (center)
        {
            cell.Elements<Paragraph>().First().ParagraphProperties =
                new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
        }

        return cell;
    }

}