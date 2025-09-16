using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Traversal.Business.Abstract;
using Traversal.Core.Concrete.Entities;
using Traversal.DataAccess.Concrete;
using TraversalProject.Models;

namespace TraversalProject.Controllers
{
    public class ExcelController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IExcelService _excelService;

        public ExcelController(AppDbContext appDbContext, IExcelService excelService)
        {
            _appDbContext = appDbContext;
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            destinationModels = _appDbContext.Destinations.Select(x => new DestinationModel
            {
                City = x.City,
                Capacity = x.Capacity,
                DayNight = x.DayNight,
                Price = x.Price,
            }).ToList();
            return destinationModels;
        }

        public IActionResult StaticExcelReport()
        {
            return File(_excelService.ExcelList(DestinationList()), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NewExFile.xlsx");
        }

        public IActionResult DestinationExcelReport()
        {
            using(var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Destination List");
                workSheet.Cell(1, 1).Value = "City";
                workSheet.Cell(1, 2).Value = "Day Night";
                workSheet.Cell(1, 3).Value = "Price";
                workSheet.Cell(1, 4).Value = "Capacity";


                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.City;
                    workSheet.Cell(rowCount, 2).Value = item.DayNight;
                    workSheet.Cell(rowCount, 3).Value = item.Price;
                    workSheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }
                workSheet.Columns().AdjustToContents();
                workSheet.Rows().AdjustToContents();

                using(var stream = new  MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DestinationList.xlsx");
                }
            }
        }
    }
}
