using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ExpCsb1
    {
        public decimal Csb1id { get; set; }
        public string Csb1no { get; set; }
        public DateTime? Csb1date { get; set; }
        public int? Csb1time { get; set; }
        public decimal? CourierCoId { get; set; }
        public string ThokaNo { get; set; }
        public string FlightNo { get; set; }
        public DateTime? DateofDeparture { get; set; }
        public int? TimeofDeparture { get; set; }
        public DateTime? ExpectedDateofLanding { get; set; }
        public string EcmreferenceDocNo { get; set; }
        public DateTime? EcmreferenceDocDate { get; set; }
        public decimal? EcmreferenceDocManifestWt { get; set; }
        public string EcmreferenceNonDocNo { get; set; }
        public DateTime? EcmreferenceNonDocDate { get; set; }
        public decimal? EcmreferenceNonDocManifestWt { get; set; }
        public string Mawbno { get; set; }
        public decimal? InvoiceId { get; set; }
        public decimal? ReleaseGatePassId { get; set; }
        public string RelGpClosour { get; set; }
        public string TerminalCode { get; set; }
        public string FinYear { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
    }
}
