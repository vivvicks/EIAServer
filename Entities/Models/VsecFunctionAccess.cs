using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecFunctionAccess
    {
        public int Faid { get; set; }
        public int FnId { get; set; }
        public int RoleId { get; set; }
        public int? ParentFnId { get; set; }
        public int? ApplicationId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public VsecApplications Application { get; set; }
        public VsecFunctionMst Fn { get; set; }
        public VsecRoleMst Role { get; set; }
    }
}
