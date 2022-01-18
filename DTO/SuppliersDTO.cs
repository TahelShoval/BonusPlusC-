using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SuppliersDTO
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string logo { get; set; }
        public Nullable<int> categoryID { get; set; }

    }
}
