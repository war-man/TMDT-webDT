//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheGioiDiDong_v3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            this.ChiTietDonHang = new HashSet<ChiTietDonHang>();
        }
    
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public string chitiet { get; set; }
        public string hinh { get; set; }
        public Nullable<int> gia { get; set; }
        public Nullable<int> sl_duocmua { get; set; }
        public string loaiSP { get; set; }
        public string hangSX { get; set; }
        public string tinhtrangSP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDonHang> ChiTietDonHang { get; set; }
        public virtual HangSX HangSX1 { get; set; }
    }
}