using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MGlobalMappingMst
    {
        public string LoginId { get; set; }
        public string TerminalCode { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDt { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
    }
}
