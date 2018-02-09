using System.Collections.Generic;
using ExportExcel.Models;

namespace ExportExcel.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUserList();
    }
}