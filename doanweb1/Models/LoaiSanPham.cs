using System;
using System.Collections.Generic;

namespace doanweb1.Models
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int Id { get; set; }
        public string LoaiSanPham1 { get; set; } = null!;

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
