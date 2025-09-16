using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.Business.Abstract;

namespace Traversal.Business.Concrete
{
    public class ExcelManager : IExcelService
    {
        public byte[] ExcelList<T>(List<T> t) where T : class
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                var workSheet = excelPackage.Workbook.Worksheets.Add("Page1");
                workSheet.Cells["A1"].LoadFromCollection(t, true, OfficeOpenXml.Table.TableStyles.Light10);
                workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();
               
                return excelPackage.GetAsByteArray();
            }

        }
    }
}
