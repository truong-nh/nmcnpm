//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nhom5
{
    using System;
    using System.Collections.Generic;
    
    public partial class dip_hoc_sinh_gioi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dip_hoc_sinh_gioi()
        {
            this.chi_tiet_dip_hoc_sinh_gioi = new HashSet<chi_tiet_dip_hoc_sinh_gioi>();
        }
    
        public int idDip { get; set; }
        public int nam { get; set; }
        public string moTa { get; set; }
        public string phanQuaDacBiet { get; set; }
        public string phanQuaGioi { get; set; }
        public string phanQuaKha { get; set; }
        public double tienDacBiet { get; set; }
        public double tienGioi { get; set; }
        public double tienKha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_dip_hoc_sinh_gioi> chi_tiet_dip_hoc_sinh_gioi { get; set; }
    }
}