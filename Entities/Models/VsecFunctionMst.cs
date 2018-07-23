using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecFunctionMst
    {
        public VsecFunctionMst()
        {
            VsecFunctionAccess = new HashSet<VsecFunctionAccess>();
        }

        public int FnId { get; set; }
        public string FnDisplay { get; set; }
        public string FnDesc { get; set; }
        public string FnUrl { get; set; }
        public int? FnParent { get; set; }
        public int? ApplicationId { get; set; }
        public short? FnSort { get; set; }
        public string IsActive { get; set; }
        public string AppearsInMenu { get; set; }
        public string ShowToAll { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public VsecApplications Application { get; set; }
        public ICollection<VsecFunctionAccess> VsecFunctionAccess { get; set; }
    }
}
