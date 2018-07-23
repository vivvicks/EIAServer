using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpForm1Dtl
    {
        public long Form1DtlId { get; set; }
        public long? Form1Id { get; set; }
        public string Mawbno { get; set; }
        public long? CourierCoId { get; set; }
        public string Coloader { get; set; }
        public int? NoofBags { get; set; }
        public int? NoofPackages { get; set; }
        public int? NoofShps { get; set; }
        public decimal? Weight { get; set; }
        public int? ActualNoofBags { get; set; }
        public int? ActualNoofPackages { get; set; }
        public int? ActualNoofShps { get; set; }
        public decimal? ActualWeight { get; set; }
        public string UldNo { get; set; }
        public long? InvoiceDtlId { get; set; }
        public int? VersionNo { get; set; }
    }
}
