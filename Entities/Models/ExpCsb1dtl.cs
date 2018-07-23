using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ExpCsb1dtl
    {
        public decimal Csb1dtlId { get; set; }
        public decimal? Csb1id { get; set; }
        public int? Csbtype { get; set; }
        public string ThokaNo { get; set; }
        public int? NoofBags { get; set; }
        public int? NoofPkgs { get; set; }
        public int? NoofShps { get; set; }
        public decimal? Csbweight { get; set; }
        public decimal? Csbvalue { get; set; }
        public int? VersionNo { get; set; }
    }
}
