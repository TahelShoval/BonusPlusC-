using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class WorkersBenefitsDTO
    {
        public int ID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> BenefitID { get; set; }
        public Nullable<int> WorkerID { get; set; }
        public Nullable<int> BenefitStatus { get; set; }
        public string Coupon { get; set; }
    }
}
