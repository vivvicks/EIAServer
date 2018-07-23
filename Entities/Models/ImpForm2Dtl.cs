using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpForm2Dtl
    {
        public decimal Form2DtlId { get; set; }
        public decimal? Form2Id { get; set; }
        public int? Form2Type { get; set; }
        public string ThokaNo { get; set; }
        public int? NumberofBags { get; set; }
        public int? NumberofPkgs { get; set; }
        public int? NumberofShps { get; set; }
        public decimal? WeightofShps { get; set; }
        public int? NumberofShpsTrans { get; set; }
        public int? NumberofPkgsTrans { get; set; }
        public decimal? WeightofTrans { get; set; }
        public int? VersionNo { get; set; }
    }
}
