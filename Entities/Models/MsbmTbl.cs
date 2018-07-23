using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MsbmTbl
    {
        public long MsbmId { get; set; }
        public string MsbmNumber { get; set; }
        public string NameOfCurrier { get; set; }
        public long? Pkgs { get; set; }
        public decimal? Weight { get; set; }
        public long? UbNo { get; set; }
        public long? PkgId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public string LastUpDtBy { get; set; }
    }
}
