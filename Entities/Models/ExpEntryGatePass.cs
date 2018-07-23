using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ExpEntryGatePass
    {
        public decimal EntryGatePassId { get; set; }
        public string EntryGatePassNo { get; set; }
        public DateTime? EntryGatePassDate { get; set; }
        public decimal? CourierCoId { get; set; }
        public string FlightNo { get; set; }
        public DateTime? FlightDate { get; set; }
        public int? NoofBags { get; set; }
        public int? NoofShps { get; set; }
        public int? NoofPkgs { get; set; }
        public decimal? EntryWeight { get; set; }
        public int? Csb3 { get; set; }
        public int? Csb4 { get; set; }
        public string EntryPersonStaff { get; set; }
        public string VehicleNo { get; set; }
        public string RtogatePassNo { get; set; }
        public DateTime? RtogatePassDate { get; set; }
        public string Rtoreason { get; set; }
        public string Rtoremarks { get; set; }
        public int? TimeOfDeparture { get; set; }
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
