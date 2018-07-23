using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecUserRoleMap
    {
        public long MapId { get; set; }
        public long LoginMid { get; set; }
        public int? RoleId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public VsecLoginMst LoginM { get; set; }
        public VsecRoleMst Role { get; set; }
    }
}
