using System;
using System.Collections.Generic;

namespace doanweb1.Entities
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int Id { get; set; }
        public int IdTrangThaiHoaDon { get; set; }
        public DateTime NgayMua { get; set; }
        public DateTime NgayHoanThanh { get; set; }
        public int IdKhachHang { get; set; }
        public string DiaChiGiaoHang { get; set; } = null!;
        public double TongGia { get; set; }

        public virtual KhachHang IdKhachHangNavigation { get; set; } = null!;
        public virtual TrangThaiHoaDon IdTrangThaiHoaDonNavigation { get; set; } = null!;
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
