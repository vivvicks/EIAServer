using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VrcfDebugDtl
    {
        public int? TableId { get; set; }
        public DateTime? DebugDate { get; set; }
        public string ProcName { get; set; }
        public int Sequence { get; set; }
        public string StepStr { get; set; }
        public string SqlStr { get; set; }
        public int? LogSeq { get; set; }
        public string Userid { get; set; }
        public string Ipaddress { get; set; }
        public string Sessionid { get; set; }
    }
}
