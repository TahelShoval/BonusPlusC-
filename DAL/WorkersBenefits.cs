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
    
    public partial class WorkersBenefits
    {
        public int ID { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<int> BenefitID { get; set; }
        public Nullable<int> WorkerID { get; set; }
        public Nullable<int> BenefitStatus { get; set; }
        public string Coupon { get; set; }
    
        public virtual Benefits Benefits { get; set; }
        public virtual Benefits Benefits1 { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual Suppliers Suppliers1 { get; set; }
        public virtual Workers Workers { get; set; }
    }
}
