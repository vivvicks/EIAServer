using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecUserActionHst
    {
        public long Id { get; set; }
        public string LoginId { get; set; }
        public string ActionType { get; set; }
        public string PreviousValue { get; set; }
        public string Ipaddress { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
