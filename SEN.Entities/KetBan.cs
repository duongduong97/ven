//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEN.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class KetBan
    {
        public int KetBanId { get; set; }
        public int ThanhVienId { get; set; }
        public System.DateTime ThoiGianKetBan { get; set; }
        public System.DateTime ThoiGianDongY { get; set; }
        public System.DateTime ThoiGianHuyKetBan { get; set; }
        public string TrangThai { get; set; }
    
        public virtual ThanhVien ThanhVien { get; set; }
    }
}
