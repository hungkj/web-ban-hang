using System;
using System.Collections.Generic;

namespace doanweb1.Entities
{
    public partial class Size
    {
        public Size()
        {
            SanPhamSizes = new HashSet<SanPhamSize>();
        }

        public int Id { get; set; }
        public string Size1 { get; set; } = null!;

        public virtual ICollection<SanPhamSize> SanPhamSizes { get; set; }
    }
}
