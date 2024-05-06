using System;
using System.Collections.Generic;

namespace doanweb1.Models
{
    public partial class SlideBar
    {
        public int Id { get; set; }
        public string Url { get; set; } = null!;
        public int Active { get; set; }
    }
}
