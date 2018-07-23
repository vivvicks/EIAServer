using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecApplicationAuditTrail
    {
        public long Id { get; set; }
        public long? AccessedMenuId { get; set; }
        public string AccessedMenu { get; set; }
        public string IsSuccessful { get; set; }
        public string AccessedBy { get; set; }
        public DateTime AccessedOn { get; set; }
        public string IpAddress { get; set; }
        public string SessionId { get; set; }
    }
}
