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
    
    public partial class tbl_SchoolDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SchoolDetails()
        {
            this.tbl_Holidays = new HashSet<tbl_Holidays>();
        }
    
        public int SchoolId { get; set; }
        public string SchoolType { get; set; }
        public string SchoolName { get; set; }
        public string City { get; set; }
        public int AreaId { get; set; }
        public string Address { get; set; }
        public int Zipcode { get; set; }
        public string ContactNumber { get; set; }
        public string ShortBreakTime { get; set; }
        public string LongBreakTime { get; set; }
        public int TuckShop { get; set; }
        public int PaymentMode { get; set; }
        public int IsActive { get; set; }
    
        public virtual tbl_Area tbl_Area { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Holidays> tbl_Holidays { get; set; }
        public virtual tbl_PaymentModeType tbl_PaymentModeType { get; set; }
    }
}
