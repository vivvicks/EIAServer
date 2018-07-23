using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ExpCsb1weightAcceptance
    {
        public decimal Csb1waid { get; set; }
        public decimal? Csb1id { get; set; }
        public string Uomcode { get; set; }
        public string WeightRecordedBy { get; set; }
        public string AirlineEmpId { get; set; }
        public string LeoissuedBy { get; set; }
        public string CourierRepresentativeName { get; set; }
        public int? FirstBagRecordTm { get; set; }
        public int? LastBagRecordTm { get; set; }
        public string Obcname { get; set; }
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
