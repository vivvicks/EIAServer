using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ExpReleasePass
    {
        public decimal ReleasePassId { get; set; }
        public decimal? Csb1id { get; set; }
        public string ReleasePassNo { get; set; }
        public DateTime? ReleasePassDate { get; set; }
        public int? ReleasePassTime { get; set; }
        public string AirlineStaff { get; set; }
        public string HandlingStaff { get; set; }
        public string CourierCoStaff { get; set; }
        public string Eicirepresentative { get; set; }
        public string Remarks { get; set; }
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
