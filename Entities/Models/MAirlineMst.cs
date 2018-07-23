using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MAirlineMst
    {
        public int AirlineId { get; set; }
        public string AirlineCode { get; set; }
        public string AirlineName { get; set; }
        public string AirlinePrefix { get; set; }
        public string AirlineAccountingPrefix { get; set; }
        public string TerminalCode { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string ContactEmail { get; set; }
        public string AirlineAddress1 { get; set; }
        public string AirlineAddress2 { get; set; }
        public string XrayApplicable { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
