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
    
    public partial class tbl_CouponCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CouponCategory()
        {
            this.tbl_Discount = new HashSet<tbl_Discount>();
        }
    
        public int CategoryId { get; set; }
        public string CategoryType { get; set; }
        public string IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Discount> tbl_Discount { get; set; }
    }
}
