using iText.IO.Font;
using iText.Kernel.Events;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Layout;
using iText.Layout.Properties;
using iText.Layout.Renderer;
using System.Linq;
using Rectangle = iText.Kernel.Geom.Rectangle;
using Path = System.IO.Path;

namespace DAABOM
{
    internal static class PDFGenerator
    {
        static readonly PdfFont ISOFont = PdfFontFactory
            .CreateFont(Properties.Resources.osifont, PdfEncodings.WINANSI, PdfFontFactory.EmbeddingStrategy.FORCE_EMBEDDED);
        static readonly PdfFont BarcodeFont = PdfFontFactory
            .CreateFont(Properties.Resources.LibreBarcode39Text_Regular, PdfEncodings.WINANSI, PdfFontFactory.EmbeddingStrategy.FORCE_EMBEDDED);
        static readonly Style docHeader = new Style()
            .SetFont(ISOFont)
            .SetFontSize(14)
            .SetTextAlignment(TextAlignment.CENTER)
            .SetBorder(Border.NO_BORDER);
        static readonly Style barcode = new Style()
            .SetFont(BarcodeFont)
            .SetFontSize(24)
            .SetTextAlignment(TextAlignment.CENTER)
            .SetBorder(Border.NO_BORDER);
        static readonly Style ISOHeaderText = new Style()
            .SetFont(ISOFont)
            .SetFontSize(6)
            .SetTextAlignment(TextAlignment.CENTER)
            .SetBorderBottom(new SolidBorder(2));
        static readonly Style ISOText = new Style()
            .SetFont(ISOFont)
            .SetFontSize(6)
            .SetTextAlignment(TextAlignment.LEFT);

        static readonly float[] colPercents =
        {
            0.025f, 0.025f, 0.1f, 0.1f, 0.1f, 0.025f, 0.025f, 0.1f, 0.1f, 0.1f, 0.3f
        };

        static readonly string[] headers =
        {
            "#", "QTY", "PART NUMBER", "TITLE", "DESCRIPTION", "REV", "ORG", "SUPPLIER", "SUPPLIER PN", "MATERIAL", "NOTES"
        };

        internal static void GenerateBOM(string PN, string revision) // Maybe more
        {
            if (Program.workingFolderPath is not null)
            {
                string path = Path.Combine(Program.workingFolderPath, $"BOM_{PN}_REV_{revision}.pdf");
                FileInfo file = new(path);

                file?.Delete(); // Consider whether this might want a confirmation box

                PdfDocument PDFDocument = new(new PdfWriter(path));
                Document document = new(PDFDocument);

                TableHeaderEventHandler handler = new(document, PN, revision);
                PDFDocument.AddEventHandler(PdfDocumentEvent.END_PAGE, handler);

                PDFDocument.SetDefaultPageSize(PageSize.LETTER.Rotate());
                document.SetMargins(handler.GetTableHeight() + 24, 12, 12, 12);

                Table table = new Table(UnitValue.CreatePercentArray(colPercents)).UseAllAvailableWidth();

                foreach (string header in headers) table.AddHeaderCell(CreateCell(header, ISOHeaderText));

                for (int i = 0; i < 1000; i++) table.AddCell(CreateCell("POOP", ISOText));

                document.Add(table);

                document.Close();
            }
        }

        static Cell CreateCell(string text, Style style) => new Cell().Add(new Paragraph(text)).AddStyle(style);

        private class TableHeaderEventHandler : IEventHandler
        {
            private Table table;
            private readonly float tableHeight;
            private readonly Document doc;
            private int pageNumber;

            public TableHeaderEventHandler(Document doc, string PN, string revision)
            {
                this.doc = doc;
                pageNumber = 1;
                InitTable(PN, revision);

                TableRenderer renderer = (TableRenderer)table.CreateRendererSubTree();
                renderer.SetParent(new DocumentRenderer(doc));

                // Simulate the positioning of the renderer to find out how much space the header table will occupy.
                LayoutResult result = renderer.Layout(new LayoutContext(new LayoutArea(0, PageSize.A4)));
                tableHeight = result.GetOccupiedArea().GetBBox().GetHeight();
            }

            public void HandleEvent(Event currentEvent)
            {
                PdfDocumentEvent docEvent = (PdfDocumentEvent)currentEvent;
                PdfDocument pdfDoc = docEvent.GetDocument();
                PdfPage page = docEvent.GetPage();
                PdfCanvas canvas = new(page.NewContentStreamBefore(), page.GetResources(), pdfDoc);
                PageSize pageSize = pdfDoc.GetDefaultPageSize();
                float coordX = pageSize.GetX() + doc.GetLeftMargin();
                float coordY = pageSize.GetTop() - doc.GetTopMargin();
                float width = pageSize.GetWidth() - doc.GetRightMargin() - doc.GetLeftMargin();
                float height = GetTableHeight();
                Rectangle rect = new(coordX, coordY, width, height);

                table.GetCell(0, 2).Add(CreateCell($"BOM Sheet {pageNumber++}", docHeader));

                new Canvas(canvas, rect)
                    .Add(table)
                    .Close();
            }

            public float GetTableHeight()
            {
                return tableHeight;
            }

            private void InitTable(string PN, string revision)
            {
                table = new Table(4).UseAllAvailableWidth();

                table.AddCell(CreateCell(PN + " Rev. " + revision, docHeader));
                table.AddCell(CreateCell("Generated " + DateTime.Now.ToString(), docHeader));
                table.AddCell(CreateCell("", docHeader).SetPadding(0));
                table.AddCell(CreateCell("*" + PN + "/" + revision + new string('-', 4 - revision.Length) + "*", barcode));
            }
        }
    }
}