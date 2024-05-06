using System;
using System.Collections.Generic;

namespace doanweb1.Entities
{
    public partial class SanPhamSize
    {
        public SanPhamSize()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        public int Id { get; set; }
        public string SoLuongConLai { get; set; } = null!;
        public int IdSanPham { get; set; }
        public int IdSize { get; set; }

        public virtual SanPham IdSanPhamNavigation { get; set; } = null!;
        public virtual Size IdSizeNavigation { get; set; } = null!;
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
