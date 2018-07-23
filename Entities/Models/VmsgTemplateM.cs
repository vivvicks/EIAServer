using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VmsgTemplateM
    {
        public VmsgTemplateM()
        {
            VmsgRelation = new HashSet<VmsgRelation>();
        }

        public long TemplateId { get; set; }
        public string TemplateDesc { get; set; }
        public string TemplateSubject { get; set; }
        public string TemplateData { get; set; }
        public string ImagePath { get; set; }
        public string ContentType { get; set; }
        public string MailType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public ICollection<VmsgRelation> VmsgRelation { get; set; }
    }
}
