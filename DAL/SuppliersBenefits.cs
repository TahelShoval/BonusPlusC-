//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SuppliersBenefits
    {
        public int ID { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> BenefitId { get; set; }
        public Nullable<int> Price { get; set; }
    
        public virtual Benefits Benefits { get; set; }
        public virtual Suppliers Suppliers { get; set; }
    }
}
