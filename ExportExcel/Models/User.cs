using System;
using System.Linq;

namespace ExportExcel.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime BirthDate { get; set; }

        public Guid UserId { get; set; }

        public User()
        {
            Name = string.Join("", Guid.NewGuid().ToString("n").Take(8).Select(o => o));
            Surname = string.Join("", Guid.NewGuid().ToString("n").Take(8).Select(o => o));
            UserId = Guid.NewGuid();
            BirthDate = DateTime.Now;
        }

    }
}
