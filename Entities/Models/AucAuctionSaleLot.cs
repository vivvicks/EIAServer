using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AucAuctionSaleLot
    {
        public decimal AucSaleLotId { get; set; }
        public string AucSaleLotNo { get; set; }
        public decimal? AucListDtlId { get; set; }
        public string Status { get; set; }
        public string TerminalCode { get; set; }
        public string FinancialYear { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
    }
}
