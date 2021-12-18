using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkersDTO
    {
        public int ID { get; set; }
        public Nullable<int> EmployerID { get; set; }
        public string WorkerID { get; set; }
        public string WorkerName { get; set; }
        public Nullable<int> JobType { get; set; }
        public Nullable<int> Seniority { get; set; }
        public string Email { get; set; }
        public string WorkerUserName { get; set; }
        public string WorkerPassword { get; set; }
    }
}
