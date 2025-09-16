using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract;
using Traversal.Business.Reports;
using Traversal.Business.Reports.PDF;

namespace Traversal.Business.Concrete
{
    public class PdfManager : IPdfService
    {
        private readonly IGuideService _guideService;

        public PdfManager(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public byte[] GenerateTestReport()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            var document = new TestReport();
            return document.GeneratePdf();
        }

        public byte[] GenerateGuideReport()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            var guides = _guideService.GetAll();
            var document = new GuideReportDocument(guides);
            return document.GeneratePdf();  
        }
    }
}
