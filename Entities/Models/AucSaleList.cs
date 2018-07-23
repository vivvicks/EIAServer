using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AucSaleList
    {
        public int AucSaleListId { get; set; }
        public decimal? AucListId { get; set; }
        public string BidderName { get; set; }
        public string BidderAddr1 { get; set; }
        public string BidderAddr2 { get; set; }
        public string BidderIdNo { get; set; }
        public string BidderPhoneNo { get; set; }
        public string VattinNo { get; set; }
        public DateTime? AucSaleListDate { get; set; }
        public string TerminalCode { get; set; }
        public string FinancialYear { get; set; }
        public string McStatus { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
