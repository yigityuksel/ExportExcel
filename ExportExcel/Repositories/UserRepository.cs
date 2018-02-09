using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExportExcel.Interfaces;
using ExportExcel.Models;

namespace ExportExcel.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetUserList()
        {
            return new List<User>()
            {
                new User(), new User(), new User(), new User(), new User(),new User(), new User(), new User(), new User(), new User()
            };
        }
    }
}
