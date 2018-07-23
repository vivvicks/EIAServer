using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecProfileMst
    {
        public VsecProfileMst()
        {
            VsecLoginMst = new HashSet<VsecLoginMst>();
        }

        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public int PwdExpDays { get; set; }
        public int PwdRetryCount { get; set; }
        public int PwdGracePeriod { get; set; }
        public int? NoofSessions { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }

        public ICollection<VsecLoginMst> VsecLoginMst { get; set; }
    }
}
