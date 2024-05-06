using System;
using System.Collections.Generic;

namespace doanweb1.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Id { get; set; }
        public string? TenDangNhap { get; set; }
        public string? MatKhau { get; set; }
        public string DiaChi { get; set; } = null!;
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
