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
        public int WorkerID { get; set; }
        public Nullable<int> SupplierBenefitID { get; set; }
        public Nullable<int> BenefitStatus { get; set; }
        public Nullable<int> Coupon { get; set; }
    }
}
