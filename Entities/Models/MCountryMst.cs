using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MCountryMst
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
