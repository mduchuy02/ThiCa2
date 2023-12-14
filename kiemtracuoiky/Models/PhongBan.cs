using System;
using System.Collections.Generic;

namespace kiemtracuoiky.Models
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            NhanVien = new HashSet<NhanVien>();
        }

        public string Mapb { get; set; }
        public string Tenpb { get; set; }

        public ICollection<NhanVien> NhanVien { get; set; }
    }
}
