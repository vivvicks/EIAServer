using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VrcfXlsxStyle
    {
        public string Stylename { get; set; }
        public string Fontname { get; set; }
        public int Fontsize { get; set; }
        public string Fontcolor { get; set; }
        public string Isbold { get; set; }
        public string Fillcolor { get; set; }
    }
}
