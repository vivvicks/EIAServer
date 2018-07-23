using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MAirportMst
    {
        public string AirportCode { get; set; }
        public string AirportDesc { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
