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
    
    public partial class tbl_PaymentDetails
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public string TransactionId { get; set; }
        public decimal OrderAmount { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TotalOrderAmount { get; set; }
        public string PaymentStatus { get; set; }
        public Nullable<System.DateTime> PaidDate { get; set; }
        public int RefundStatus { get; set; }
        public string RefundType { get; set; }
        public string IssuedBy { get; set; }
        public Nullable<decimal> RefundAmount { get; set; }
        public Nullable<System.DateTime> RefundDate { get; set; }
        public Nullable<int> OrderId { get; set; }
    }
}
