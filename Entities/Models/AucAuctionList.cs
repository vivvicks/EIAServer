using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AucAuctionList
    {
        public decimal AucListId { get; set; }
        public string AucListNo { get; set; }
        public DateTime? AucListDate { get; set; }
        public int? AucListTime { get; set; }
        public string Tr6challanNo { get; set; }
        public DateTime? Tr6challanDate { get; set; }
        public decimal? DutyAmount { get; set; }
        public int? Mopcode { get; set; }
        public string BankName { get; set; }
        public string ChequeNo { get; set; }
        public DateTime? ChequeDate { get; set; }
        public int? Notice2RefNo { get; set; }
        public string TerminalCode { get; set; }
        public string FinancialYear { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
    }
}
