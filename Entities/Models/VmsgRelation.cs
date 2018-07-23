using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class VmsgRelation
    {
        public long RelationId { get; set; }
        public long AlertId { get; set; }
        public long TemplateId { get; set; }

        public VmsgAlertM Alert { get; set; }
        public VmsgTemplateM Template { get; set; }
    }
}
