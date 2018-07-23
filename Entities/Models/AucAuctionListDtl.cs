using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AucAuctionListDtl
    {
        public decimal AucListDtlId { get; set; }
        public decimal? AucListId { get; set; }
        public decimal? OnHoldId { get; set; }
        public string MemoNo { get; set; }
        public string AucStatus { get; set; }
        public string AucRemarks { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public int? ItemLotId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
    }
}
