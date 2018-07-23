using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AucBoegroup
    {
        public decimal AucGroupId { get; set; }
        public string AucGroupName { get; set; }
        public decimal? AucBoeid { get; set; }
        public string AucSaleLotNo { get; set; }
        public decimal? FairPrice { get; set; }
        public decimal? SalePrice { get; set; }
        public decimal? RateSd { get; set; }
        public decimal? Bcd { get; set; }
        public decimal? Cvd { get; set; }
        public decimal? Custom { get; set; }
        public decimal? AdditonalCdrate { get; set; }
        public decimal? AdditiaonlCdamount { get; set; }
        public decimal? TotalDutyRate { get; set; }
        public decimal? TotalDuty { get; set; }
        public string AdditionalInfo { get; set; }
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
