using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BenefitsDTO
    {
        public int BenefitID { get; set; }
        public string Details { get; set; }
        public string Image { get; set; }
        public Nullable<int> price { get; set; }
    }
}
