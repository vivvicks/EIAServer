using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecQuestionMst
    {
        public VsecQuestionMst()
        {
            VsecLoginMstQuestionId1Navigation = new HashSet<VsecLoginMst>();
            VsecLoginMstQuestionId2Navigation = new HashSet<VsecLoginMst>();
            VsecLoginMstQuestionId3Navigation = new HashSet<VsecLoginMst>();
        }

        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<VsecLoginMst> VsecLoginMstQuestionId1Navigation { get; set; }
        public ICollection<VsecLoginMst> VsecLoginMstQuestionId2Navigation { get; set; }
        public ICollection<VsecLoginMst> VsecLoginMstQuestionId3Navigation { get; set; }
    }
}
