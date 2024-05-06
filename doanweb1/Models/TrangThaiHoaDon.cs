using System;
using System.Collections.Generic;

namespace doanweb1.Models
{
    public partial class TrangThaiHoaDon
    {
        public TrangThaiHoaDon()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public int Id { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
