using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AucBoe
    {
        public decimal AucBoeid { get; set; }
        public string AucBoeno { get; set; }
        public decimal? AucListId { get; set; }
        public DateTime? AucBoedate { get; set; }
        public string BidderName { get; set; }
        public string BidderVattinNo { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? AuctionDate { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Vatperc { get; set; }
        public decimal? Vat { get; set; }
        public decimal? OtherCharges { get; set; }
        public string Tr6challanNo { get; set; }
        public DateTime? Tr6challanDate { get; set; }
        public decimal? DutyAmount { get; set; }
        public int? Mopcode { get; set; }
        public string BankName { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
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
