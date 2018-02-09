using System;
using System.Collections.Generic;
using ExportExcel.Interfaces;
using ExportExcel.Models;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace ExportExcel.Services
{
    public class ExportExcelService : IExportExcelService
    {

        private readonly int _defaultRowHeight = 12;
        private readonly int _headerHeight = 20;

        public byte[] ExportUsers(List<User> userList)
        {

            using (var excelPackage = new ExcelPackage())
            {

                var workSheet = excelPackage.Workbook.Worksheets.Add("Sheet1");
                workSheet.DefaultRowHeight = _defaultRowHeight;

                /*Header of Table*/
                workSheet.Row(1).Height = _headerHeight;
                workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                workSheet.Row(1).Style.Font.Bold = true;

                workSheet.Cells[1, 2].Value = "Id";
                workSheet.Cells[1, 3].Value = "Name";
                workSheet.Cells[1, 4].Value = "Surname";
                workSheet.Cells[1, 5].Value = "BirthDate";

                /*Body of Table*/
                int recordIndex = 2;
                foreach (var item in userList)
                {
                    workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
                    workSheet.Cells[recordIndex, 2].Value = item.UserId;
                    workSheet.Cells[recordIndex, 3].Value = item.Name;
                    workSheet.Cells[recordIndex, 4].Value = item.Surname;
                    workSheet.Cells[recordIndex, 5].Value = item.BirthDate.ToString("dd/MM/yyyy HH:mm:ss.fff");
                    recordIndex++;
                }

                /*fit the columns*/
                workSheet.Column(1).AutoFit();
                workSheet.Column(2).AutoFit();
                workSheet.Column(3).AutoFit();
                workSheet.Column(4).AutoFit();

                return excelPackage.GetAsByteArray();

            }

        }
    }
}
