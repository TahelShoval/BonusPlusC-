using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class EmployersDTO
    {
        public int EmployerID { get; set; }
        public string CompanyName { get; set; }
        public string NameEmployer { get; set; }
        public Nullable<int> AddressID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string EmployerUserName { get; set; }
        public string EmployerPassword { get; set; }
    }
}
