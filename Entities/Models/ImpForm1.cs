using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpForm1
    {
        public long Form1Id { get; set; }
        public string Form1No { get; set; }
        public string FlightNumber { get; set; }
        public string AirportOfShipment { get; set; }
        public string IgmNo { get; set; }
        public int? ProvisionalIgmno { get; set; }
        public DateTime? IgmDate { get; set; }
        public int? TimeOfArrival { get; set; }
        public DateTime? DateOfArrival { get; set; }
        public string SupervisorName { get; set; }
        public string SecurityOfficer { get; set; }
        public string AirlineEmpName { get; set; }
        public string CustomOfficer { get; set; }
        public string DutyOfficer { get; set; }
        public string CourierRepresentative { get; set; }
        public string FinYear { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
    }
}
