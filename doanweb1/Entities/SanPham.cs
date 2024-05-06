using System;
using System.Collections.Generic;

namespace doanweb1.Entities
{
    public partial class SanPham
    {
        public SanPham()
        {
            HinhAnhs = new HashSet<HinhAnh>();
            SanPhamSizes = new HashSet<SanPhamSize>();
        }

        public int Id { get; set; }
        public string TenSp { get; set; } = null!;
        public int LoaiSp { get; set; }
        public string Chitietsanpham { get; set; } = null!;
        public string? GiaSp { get; set; }

        public virtual LoaiSanPham LoaiSpNavigation { get; set; } = null!;
        public virtual ICollection<HinhAnh> HinhAnhs { get; set; }
        public virtual ICollection<SanPhamSize> SanPhamSizes { get; set; }
    }
}
