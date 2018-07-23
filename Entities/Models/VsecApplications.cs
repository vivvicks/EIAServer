using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecApplications
    {
        public VsecApplications()
        {
            VsecFunctionAccess = new HashSet<VsecFunctionAccess>();
            VsecFunctionMst = new HashSet<VsecFunctionMst>();
        }

        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationPath { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<VsecFunctionAccess> VsecFunctionAccess { get; set; }
        public ICollection<VsecFunctionMst> VsecFunctionMst { get; set; }
    }
}
