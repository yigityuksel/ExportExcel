using System.Collections.Generic;
using ExportExcel.Models;

namespace ExportExcel.Interfaces
{
    public interface IExportExcelService
    {
        byte[] ExportUsers(List<User> userList);
    }
}