using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkerBenefits
    {
        public int ID { get; set; }
        public Nullable<int> SupplierBenefitID { get; set; }
        public string SupplierName { get; set; }
        public string Supplierlogo { get; set; }
        public string BenefitDetails { get; set; }
        public string BenefitImage { get; set; }
        public Nullable<int> WorkerID { get; set; }
        public Nullable<int> BenefitStatus { get; set; }
        public Nullable<int> Coupon { get; set; }

    }
}
