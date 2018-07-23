using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ExpCsb1weightAcceptanceDtl
    {
        public decimal Csb1wadtlId { get; set; }
        public decimal? Csb1waid { get; set; }
        public int? NoofBags { get; set; }
        public string Uomcode { get; set; }
        public decimal? Waweight { get; set; }
        public string TagNo { get; set; }
        public int? VersionNo { get; set; }
    }
}
