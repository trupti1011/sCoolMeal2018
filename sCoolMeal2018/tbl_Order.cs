//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sCoolMeal2018
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Order()
        {
            this.tbl_Scheduler = new HashSet<tbl_Scheduler>();
        }
    
        public int OrderId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> ChildId { get; set; }
        public Nullable<int> PackageId { get; set; }
        public Nullable<int> OrderTypeId { get; set; }
        public Nullable<int> MenuId { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int OrderComplete { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public Nullable<System.DateTime> Validity { get; set; }
        public Nullable<decimal> TotalOrderAmount { get; set; }
        public int OrderCurrent { get; set; }
        public Nullable<System.DateTime> OrderUpdateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string OrderUpdateReason { get; set; }
        public Nullable<int> PaymentId { get; set; }
    
        public virtual tbl_ChildDetails tbl_ChildDetails { get; set; }
        public virtual tbl_OrderType tbl_OrderType { get; set; }
        public virtual tbl_PackageDetails tbl_PackageDetails { get; set; }
        public virtual tbl_ParentDetails tbl_ParentDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Scheduler> tbl_Scheduler { get; set; }
    }
}
