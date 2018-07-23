using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpGatePassDtl
    {
        public decimal GatePassDtlId { get; set; }
        public decimal? GatePassId { get; set; }
        public int? Form2Type { get; set; }
        public string ThokaNo { get; set; }
        public int? NoofPkgs { get; set; }
        public int? NoofBags { get; set; }
        public int? NoofShipments { get; set; }
        public decimal? Weight { get; set; }
        public int? VersionNo { get; set; }
    }
}
