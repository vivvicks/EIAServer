using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MUserTypeMst
    {
        public int UserTypeId { get; set; }
        public string UserTypeCode { get; set; }
        public string UserTypeDesc { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
