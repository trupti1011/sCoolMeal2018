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
    
    public partial class tbl_AgeGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_AgeGroup()
        {
            this.tbl_ChildDetails = new HashSet<tbl_ChildDetails>();
            this.tbl_PackageDetails = new HashSet<tbl_PackageDetails>();
        }
    
        public int AgeGroupId { get; set; }
        public string Class { get; set; }
        public string AgeGroupType { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChildDetails> tbl_ChildDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PackageDetails> tbl_PackageDetails { get; set; }
    }
}
