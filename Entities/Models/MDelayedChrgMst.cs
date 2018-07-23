using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MDelayedChrgMst
    {
        public int ChargesId { get; set; }
        public string ChargeType { get; set; }
        public string TerminalCode { get; set; }
        public string Module { get; set; }
        public int? FormType { get; set; }
        public decimal? DaysFrom { get; set; }
        public decimal? DaysTo { get; set; }
        public decimal? Rate { get; set; }
        public string Per { get; set; }
        public string Uom { get; set; }
        public decimal? PrevSlabAmt { get; set; }
        public decimal? MinCap { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
