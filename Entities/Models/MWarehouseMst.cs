using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MWarehouseMst
    {
        public string WarehouseCode { get; set; }
        public string WarehouseLocation { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
