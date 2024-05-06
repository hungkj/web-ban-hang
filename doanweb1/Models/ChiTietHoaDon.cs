using System;
using System.Collections.Generic;

namespace doanweb1.Models
{
    public partial class ChiTietHoaDon
    {
        public int Id { get; set; }
        public int IdSanPhamSize { get; set; }
        public string SoLuongMua { get; set; } = null!;
        public double DonGia { get; set; }
        public int IdHoaDon { get; set; }

        public virtual HoaDon IdHoaDonNavigation { get; set; } = null!;
        public virtual SanPhamSize IdSanPhamSizeNavigation { get; set; } = null!;
    }
}
