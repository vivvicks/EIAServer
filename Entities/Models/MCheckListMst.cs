using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MCheckListMst
    {
        public int CheckListId { get; set; }
        public string CheckListDesc { get; set; }
        public string CheckListType { get; set; }
        public string CheckListValue1 { get; set; }
        public string CheckListValue2 { get; set; }
        public string Required { get; set; }
        public string Module { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
