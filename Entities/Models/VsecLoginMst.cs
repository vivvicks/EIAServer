using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VsecLoginMst
    {
        public VsecLoginMst()
        {
            VsecUserRoleMap = new HashSet<VsecUserRoleMap>();
        }

        public long LoginMid { get; set; }
        public long? UserMstId { get; set; }
        public string LoginId { get; set; }
        public string Password { get; set; }
        public int ProfileId { get; set; }
        public int? QuestionId1 { get; set; }
        public string Answer1 { get; set; }
        public int? QuestionId2 { get; set; }
        public string Answer2 { get; set; }
        public int? QuestionId3 { get; set; }
        public string Answer3 { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public string ActiveStatus { get; set; }
        public DateTime? LastPasswordChangeDate { get; set; }
        public string LastPassword { get; set; }
        public int? PasswordRetry { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public VsecProfileMst Profile { get; set; }
        public VsecQuestionMst QuestionId1Navigation { get; set; }
        public VsecQuestionMst QuestionId2Navigation { get; set; }
        public VsecQuestionMst QuestionId3Navigation { get; set; }
        public VsecUserMst UserMst { get; set; }
        public ICollection<VsecUserRoleMap> VsecUserRoleMap { get; set; }
    }
}
