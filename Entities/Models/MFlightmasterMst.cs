using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MFlightmasterMst
    {
        public string FlightNumber { get; set; }
        public string MigratedFlightNumber { get; set; }
        public string AirlineCode { get; set; }
        public string AirportofDeparture { get; set; }
        public string AirportofDestination { get; set; }
        public int? Etd { get; set; }
        public int? Eta { get; set; }
        public string FlightType { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
