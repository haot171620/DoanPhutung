//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhuTungXeMay2019.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTACT
    {
        public int idContact { get; set; }
        public string tenContact { get; set; }
        public string noidungContact { get; set; }
        public Nullable<int> idNguoidung { get; set; }
        public string tenNguoidung { get; set; }
        public byte[] hinhanhNguoidung { get; set; }
        public string gioitinh { get; set; }
        public string diachi { get; set; }
        public Nullable<int> sdt { get; set; }
        public string ghichu { get; set; }
    }
}
