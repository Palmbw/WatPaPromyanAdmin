﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatPaPromyanAdmin.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WatPaPromyanEntities : DbContext
    {
        public WatPaPromyanEntities()
            : base("name=WatPaPromyanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_m_banner> tb_m_banner { get; set; }
        public virtual DbSet<tb_m_img_menu_detail> tb_m_img_menu_detail { get; set; }
        public virtual DbSet<tb_m_img_menu_detail_banner> tb_m_img_menu_detail_banner { get; set; }
        public virtual DbSet<tb_m_menu> tb_m_menu { get; set; }
    }
}
