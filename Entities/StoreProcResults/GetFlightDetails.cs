using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.StoreProcResults
{
    public class GetFlightDetails
    {
        public string AirportofDeparture { get; set; }
        public string AirportofDestination { get; set; }
        public string AirlineName { get; set; }
        public int AirlineId { get; set; }
        public string ETA { get; set; }
        public string ETD { get; set; }
        public string AirlineAccountingPrefix { get; set; }

    }
}
