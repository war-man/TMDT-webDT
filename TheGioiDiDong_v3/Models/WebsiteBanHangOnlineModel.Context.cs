﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class banhangEntities1 : DbContext
    {
        public banhangEntities1()
            : base("name=banhangEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietDonHang> ChiTietDonHang { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<HangSX> HangSX { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<LienHe> LienHe { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TuyenDung> TuyenDung { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
