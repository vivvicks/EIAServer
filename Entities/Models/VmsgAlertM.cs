using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VmsgAlertM
    {
        public VmsgAlertM()
        {
            VmsgRelation = new HashSet<VmsgRelation>();
        }

        public long AlertId { get; set; }
        public string AlertDesc { get; set; }
        public byte? AlertPriority { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string SendType { get; set; }
        public int? DisclaimerId { get; set; }
        public string Attachment { get; set; }
        public string Sourceemail { get; set; }
        public string ToId { get; set; }
        public string ToGroup { get; set; }
        public string Cc { get; set; }
        public string CcGroup { get; set; }
        public string Bcc { get; set; }
        public string BccGroup { get; set; }
        public string DoNotSendDay { get; set; }
        public string MessageSubject { get; set; }
        public string BodyAsAttachment { get; set; }
        public string AttachmentName { get; set; }
        public string BodyMessageText { get; set; }
        public string AttachmentBaseFolder { get; set; }
        public string Sensitivity { get; set; }
        public int? SendPickDay { get; set; }
        public int? SendPickHour { get; set; }
        public string DisplaySenderName { get; set; }
        public string ModuleName { get; set; }

        public ICollection<VmsgRelation> VmsgRelation { get; set; }
    }
}
