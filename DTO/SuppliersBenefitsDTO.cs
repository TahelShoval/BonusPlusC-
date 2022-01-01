using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuppliersBenefitsDTO
    {
        public int ID { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> BenefitId { get; set; }
    }
}
