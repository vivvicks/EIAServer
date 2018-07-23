using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MModeofpaymentMst
    {
        public string Mopcode { get; set; }
        public string Mopdesc { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
    }
}
