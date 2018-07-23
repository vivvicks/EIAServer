using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecRoleMst
    {
        public VsecRoleMst()
        {
            VsecFunctionAccess = new HashSet<VsecFunctionAccess>();
            VsecUserRoleMap = new HashSet<VsecUserRoleMap>();
        }

        public int RoleId { get; set; }
        public int? ParentRoleId { get; set; }
        public string RoleSname { get; set; }
        public string DisplayName { get; set; }
        public string ActiveFlag { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }

        public ICollection<VsecFunctionAccess> VsecFunctionAccess { get; set; }
        public ICollection<VsecUserRoleMap> VsecUserRoleMap { get; set; }
    }
}
