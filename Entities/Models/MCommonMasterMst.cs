using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MCommonMasterMst
    {
        public int MasterId { get; set; }
        public string MasterDesc { get; set; }
        public string MasterType { get; set; }
        public string MasterValue1 { get; set; }
        public string MasterValue2 { get; set; }
        public string MasterValue3 { get; set; }
        public string MasterValue4 { get; set; }
        public string MasterValue5 { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
