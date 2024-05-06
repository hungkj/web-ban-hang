using System;
using System.Collections.Generic;

namespace doanweb1.Models
{
    public partial class HinhAnh
    {
        public int Id { get; set; }
        public int IdSanPham { get; set; }
        public string Image { get; set; } = null!;

        public virtual SanPham IdSanPhamNavigation { get; set; } = null!;
    }
}
