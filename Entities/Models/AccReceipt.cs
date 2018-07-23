using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AccReceipt
    {
        public decimal ReceiptId { get; set; }
        public string ReceiptNo { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public long? CourierCoId { get; set; }
        public decimal? ServiceTaxAmount { get; set; }
        public string TerminalCode { get; set; }
        public string Remarks { get; set; }
        public int? FinYear { get; set; }
        public int? ReceiptTypeId { get; set; }
        public int? ReceiptChargeTypeId { get; set; }
        public decimal? GatePassId { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? FlightDate { get; set; }
        public string ExportedtoTally { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
    }
}
