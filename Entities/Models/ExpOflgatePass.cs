using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ExpOflgatePass
    {
        public int Oflgpid { get; set; }
        public int EntryGatePassId { get; set; }
        public string OfficerName { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public int? NoOfBags { get; set; }
        public int? NoofShps { get; set; }
        public int? NoofPkgs { get; set; }
        public decimal? Oflweight { get; set; }
        public int? Csb3 { get; set; }
        public int? Csb4 { get; set; }
        public string OffloadingPersonStaff { get; set; }
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
