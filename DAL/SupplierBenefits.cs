using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierBenefits
    {
        public int ID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierLogo { get; set; }
        public string BenefitDetails { get; set; }
        public string BenefitImage { get; set; }
        public Nullable<int> Price { get; set; }
    }
}
