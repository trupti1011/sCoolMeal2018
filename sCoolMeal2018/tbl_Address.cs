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
    
    public partial class tbl_Address
    {
        public int AddressId { get; set; }
        public int ParentId { get; set; }
        public int AreaId { get; set; }
        public int AddressTypeId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int Zipcode { get; set; }
        public int IsActive { get; set; }
    
        public virtual tbl_AddressType tbl_AddressType { get; set; }
        public virtual tbl_Area tbl_Area { get; set; }
        public virtual tbl_ParentDetails tbl_ParentDetails { get; set; }
    }
}
