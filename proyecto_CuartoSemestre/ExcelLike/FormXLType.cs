using System;
using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
using System.Diagnostics;
using System.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace proyecto_CuartoSemestre
{
    public partial class FormXLType : Form
    {
        public FormXLType()
        {
            InitializeComponent();
            lstvDatos.View = View.Details;
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogo = new OpenFileDialog();
            if (dialogo.ShowDialog() != DialogResult.OK)
            { return; }
            lstvDatos.Clear();

            string[] lineas = File.ReadAllLines(dialogo.FileName);

            Array[] datos = new Array[lineas.Count()];
            for (int i = 0; i < lineas.Length; i++)
            { datos[i] = lineas[i].Split('|'); }

            Array cabecera = datos[0];
            for (int i = 0; i < cabecera.Length; i++)
            {
                //MessageBox.Show(cabecera.GetValue(i).ToString());
                lstvDatos.Columns.Add(cabecera.GetValue(i).ToString());
            }
            for (int i = 1; i < datos.Length; i++)
            {
                ListViewItem item = new ListViewItem(datos[i].GetValue(0).ToString());
                for (int j = 1; j < datos[i].Length; j++)
                {
                    item.SubItems.Add(datos[i].GetValue(j).ToString());
                }
                lstvDatos.Items.Add(item);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Separated Values | *.csv | Texto | *.txt | Excel | *.xlsx";

            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            StreamWriter sw = new StreamWriter(sfd.FileName);

            foreach (ListViewItem item in lstvDatos.Items)
            {
                int i = 1;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (i == lstvDatos.Columns.Count)
                    {
                        sw.Write(subItem.Text);
                        sw.WriteLine();
                        i = 0;
                    }
                    else
                    { sw.Write(subItem.Text + ","); i++; }
                }
            }
            sw.Close();
            MessageBox.Show("Done");
        }

        private void btnGuardarExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            if (sfd.FileName != "")
            {
                Excel.Application excel;
                try { excel = new Excel.Application(); }
                catch { MessageBox.Show("para este metodo de excel es necesario tener instalado Microsoft Excel"); return; }
                Excel.Workbook workbook = excel.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = null;

                try
                {
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "ListView Data";

                    int row = 1;
                    int col = 1;

                    foreach (ColumnHeader column in lstvDatos.Columns)
                    {
                        worksheet.Cells[row, col] = column.Text;
                        col++;
                    }
                    row++;

                    foreach (ListViewItem item in lstvDatos.Items)
                    {
                        col = 1;
                        foreach (ListViewItem.ListViewSubItem subitem in item.SubItems)
                        {
                            worksheet.Cells[row, col] = subitem.Text;
                            col++;
                        }
                        row++;
                    }

                    workbook.SaveAs(sfd.FileName);
                    Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                { MessageBox.Show("Error: " + ex.Message); }

                excel.Quit();
                workbook = null;
                excel = null;
                MessageBox.Show("Done");
            }
        }

        private void btnExcelOpenXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            if (sfd.FileName != "")
            {
                SpreadsheetDocument document = SpreadsheetDocument.Create(sfd.FileName, SpreadsheetDocumentType.Workbook);
                // Agregar una hoja de trabajo
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());
                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet() { Id = workbookPart.GetIdOfPart(worksheetPart), SheetId = 1, Name = "ListView" };
                sheets.Append(sheet);

                // Obtener la colección de celdas
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Recorrer las columnas y filas de la ListView
                for (int i = 0; i < lstvDatos.Columns.Count; i++)
                {
                    // Crear una fila para los encabezados
                    if (i == 0)
                    {
                        Row row = new Row() { RowIndex = 1 };
                        sheetData.Append(row);
                    }
                    // Obtener el encabezado de la columna
                    string headerText = lstvDatos.Columns[i].Text;
                    // Crear una celda para el encabezado
                    Cell headerCell = new Cell();
                    headerCell.CellReference = GetColumnName(i + 1) + "1";
                    headerCell.DataType = CellValues.String;
                    headerCell.CellValue = new CellValue(headerText);

                    // Agregar la celda al final de la fila
                    Row headerRow = (Row)sheetData.ChildElements.GetItem(0);
                    headerRow.AppendChild(headerCell);

                    // Recorrer las filas de la columna
                    for (int j = 0; j < lstvDatos.Items.Count; j++)
                    {
                        // Crear una fila para los datos
                        if (i == 0)
                        {
                            Row row = new Row() { RowIndex = (uint)(j + 2) };
                            sheetData.Append(row);
                        }
                        // Obtener el valor del dato
                        string dataText = lstvDatos.Items[j].SubItems[i].Text;
                        // Crear una celda para el dato
                        Cell dataCell = new Cell();
                        dataCell.CellReference = GetColumnName(i + 1) + (j + 2);
                        dataCell.DataType = CellValues.String;
                        dataCell.CellValue = new CellValue(dataText);

                        // Agregar la celda al final de la fila
                        Row dataRow = (Row)sheetData.ChildElements.GetItem(j + 1);
                        dataRow.AppendChild(dataCell);
                    }
                }
                // Guardar y cerrar el documento
                workbookPart.Workbook.Save();
                document.Dispose();
                MessageBox.Show("Done");
            }
        }
        private string GetColumnName(int index)
        {
            int dividend = index;
            string columnName = String.Empty;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                columnName = Convert.ToChar(65 + modulo).ToString() + columnName;
                dividend = (int)((dividend - modulo) / 26);
            }

            return columnName;
        }

        private void btnGuardarWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Word files (*.docx)|*.docx|All files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            Word.Application wordApp;
            try
            { wordApp = new Word.Application(); }
            catch
            { MessageBox.Show("No tienes instalado Microsoft Word"); return; }

            wordApp.Visible = true;
            Word.Document document = wordApp.Documents.Add();

            // Obtener la referencia a la ListView

            // Exportar los encabezados de columna
            Word.Table table = document.Tables.Add(document.Range(), lstvDatos.Items.Count + 1, lstvDatos.Columns.Count);
            table.Borders.Enable = 1; // Agregar bordes a la tabla

            for (int columna = 0; columna < lstvDatos.Columns.Count; columna++)
            {
                table.Cell(1, columna + 1).Range.Text = lstvDatos.Columns[columna].Text;
            }

            // Exportar los datos de la ListView
            for (int fila = 0; fila < lstvDatos.Items.Count; fila++)
            {
                for (int columna = 0; columna < lstvDatos.Columns.Count; columna++)
                {
                    table.Cell(fila + 2, columna + 1).Range.Text = lstvDatos.Items[fila].SubItems[columna].Text;
                }
            }

            document.SaveAs(sfd.FileName);
            // Cerrar y liberar recursos
            document.Close();
            wordApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(table);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(document);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
            MessageBox.Show("Done");
        }

        private void btnGuardarPDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            // Crear un documento PDF
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sfd.FileName, FileMode.Create)); ;
            document.Open();

            // Crear la tabla
            PdfPTable table = new PdfPTable(lstvDatos.Columns.Count);
            table.WidthPercentage = 100;

            // Agregar los encabezados de columna
            for (int i = 0; i < lstvDatos.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(lstvDatos.Columns[i].Text));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                table.AddCell(cell);
            }

            // Agregar los datos de la ListView
            for (int fila = 0; fila < lstvDatos.Items.Count; fila++)
            {
                for (int columna = 0; columna < lstvDatos.Columns.Count; columna++)
                {
                    table.AddCell(lstvDatos.Items[fila].SubItems[columna].Text);
                }
            }

            // Agregar la tabla al documento
            document.Add(table);
            document.Close();

            MessageBox.Show("Done");
        }

        private void btnJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Json (*.json)|*.json|All files (*.*)|*.*";
            if (sfd.ShowDialog() != DialogResult.OK)
            { return; }

            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

            foreach (ListViewItem item in lstvDatos.Items)
            {
                Dictionary<string, string> row = new Dictionary<string, string>();

                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    string columnHeader = lstvDatos.Columns[i].Text;
                    string cellValue = item.SubItems[i].Text;
                    row.Add(columnHeader, cellValue);
                }

                data.Add(row);
            }
            StreamWriter sw = new StreamWriter(sfd.FileName);
            sw.Write(JsonConvert.SerializeObject(data, Formatting.Indented));
            sw.Close();
        }
    }
}
