using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace kiemtracuoiky.Models
{
    public partial class NhanVien
    {
        [Display(Name ="ma nhan vien")]
        [Required(ErrorMessage ="ban chua nhap ma nhan vien")]
        public string Manv { get; set; }
        [Display(Name = "ten nhan vien")]
        [Required(ErrorMessage = "ban chua nhap ten nhan vien")]
        public string Hoten { get; set; }
        [Display(Name = "ngay sinh nhan vien")]
        [Required(ErrorMessage = "ban chua nhap ngay sinh nhan vien")]
        public DateTime? Ngaysinh { get; set; }
        [Display(Name = "Gioi TInh")]
        [Required(ErrorMessage = "ban chua chon gioi tinh nhan vien")]
        public bool? Gioitinh { get; set; }
        [Display(Name = "ma phong ban")]
        [Required(ErrorMessage = "ban chua nhap ma phong ban nhan vien")]
        public string Mapb { get; set; }
        [Display(Name = "he so luong nhan vien")]
        [Required(ErrorMessage = "ban chua nhap he so luong nhan vien")]
        public int? Hsluong { get; set; }
        [Display(Name = "luong co ban")]
        [Required(ErrorMessage = "ban chua nhap luong co ban nhan vien")]
        public int? Luongcb { get; set; }

        public PhongBan MapbNavigation { get; set; }
    }
}
