//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tb_m_menu
    {
        public string id { get; set; }
        public string nameMenu { get; set; }
        public string fileName { get; set; }
        public byte[] fileByte { get; set; }
        public Nullable<bool> active { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public string createBy { get; set; }
        public Nullable<System.DateTime> modifyDate { get; set; }
        public string modifyBy { get; set; }
    }
}
