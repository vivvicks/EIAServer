using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AccReceiptDtl
    {
        public int ReceiptDtlId { get; set; }
        public decimal? ReceiptId { get; set; }
        public string Mopcode { get; set; }
        public string ChequeNumber { get; set; }
        public DateTime? ChequeDate { get; set; }
        public decimal? Amount { get; set; }
        public string BankName { get; set; }
        public decimal? BalAmount { get; set; }
        public decimal? Tdsamount { get; set; }
        public int? VersionNo { get; set; }
    }
}
