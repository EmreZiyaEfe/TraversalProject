using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using Traversal.Business.Abstract;

namespace TraversalProject.Controllers
{
    public class PdfReportController : Controller
    {
        private readonly IPdfService _pdfService;

        public PdfReportController(IPdfService pdfService)
        {
            _pdfService = pdfService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            var fileBytes = _pdfService.GenerateTestReport();
            return File(fileBytes, "application/pdf", "Test.pdf");


            //string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "file1.pdf");
            //var stream = new FileStream(path, FileMode.Create);
            //Document document = new Document(PageSize.A4);
            //PdfWriter.GetInstance(document, stream);
            //document.Open();
            //Paragraph paragraph = new Paragraph("Traversal Pdf Report");
            //document.Add(paragraph);
            //document.Close();
            //return File("PdfReports/file1.pdf", "application/pdf", "file1.pdf");
        }

        public IActionResult GuideReport() 
        {
            var fileBytes = _pdfService.GenerateGuideReport();
            return File(fileBytes, "application/pdf", "GuideReport.pdf");

        //    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "file1.pdf");
        //    var stream = new FileStream(path, FileMode.Create);
        //    Document document = new Document(PageSize.A4);
        //    PdfWriter.GetInstance(document, stream);
        //    document.Open();

        //    PdfPTable pdfTable = new PdfPTable(3);
        //    pdfTable.AddCell("Guest Name");
        //    pdfTable.AddCell("Guest Surname");
        //    pdfTable.AddCell("Guest ID");

        //    pdfTable.AddCell("Emre");
        //    pdfTable.AddCell("Efe");
        //    pdfTable.AddCell("11111111111");

        //    pdfTable.AddCell("Mahmut");
        //    pdfTable.AddCell("Yıldız");
        //    pdfTable.AddCell("22222222222");

        //    pdfTable.AddCell("Halil");
        //    pdfTable.AddCell("Çelik");
        //    pdfTable.AddCell("33333333333");

        //    document.Add(pdfTable);

        //    document.Close();
        //    return File("PdfReports/file2.pdf", "application/pdf", "file2.pdf");
        }
    }
}
