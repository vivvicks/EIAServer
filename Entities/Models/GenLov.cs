using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class GenLov
    {
        public string LovId { get; set; }
        public string SqlStatement { get; set; }
        public string XmlHeader { get; set; }
        public string LovmoduleId { get; set; }
        public string Culture { get; set; }
    }
}
