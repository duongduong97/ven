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
    
    public partial class ThanhVienNhom
    {
        public int ThanhVienId { get; set; }
        public int NhomId { get; set; }
        public int Id { get; set; }
        public System.DateTime ThoiGianXacNhan { get; set; }
        public System.DateTime ThoiGianXoa { get; set; }
        public string TrangThai { get; set; }
        public System.DateTime ThoiGianYeuCauThamGia { get; set; }
    
        public virtual Nhom Nhom { get; set; }
    }
}
