using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportExcel.Repositories;
using ExportExcel.Services;

namespace ExportExcel
{
    class Program
    {
        static void Main(string[] args)
        {

            var userList = new UserRepository().GetUserList();

            var memStream = new ExportExcelService().ExportUsers(userList);

            File.WriteAllBytes("ExportList.xlsx", memStream); // For testing Purpose

        }
    }
}
