﻿//------------------------------------------------------------------------------
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
    using System.ComponentModel.DataAnnotations;
    
    public partial class CONTACT
    {
        [Display(Name="id liên hệ")]
        public int idContact { get; set; }
        [Display(Name = "Tên liên hệ")]
        public string tenContact { get; set; }
        [Display(Name = "Nội dung liên hệ")]
        public string noidungContact { get; set; }
        [Display(Name = "ID người dùng")]
        public Nullable<int> idNguoidung { get; set; }
        [Display(Name = "Tên người dùng")]
        public string tenNguoidung { get; set; }
        [Display(Name = "Hình ảnh người dùng")]
        public byte[] hinhanhNguoidung { get; set; }
        [Display(Name = "Giới tính")]
        public string gioitinh { get; set; }
        [Display(Name = "Địa chỉ")]
        public string diachi { get; set; }
        [Display(Name = "Số điện thoại")]
        public Nullable<int> sdt { get; set; }
        [Display(Name = "Ghi chú")]
        public string ghichu { get; set; }
    }
}