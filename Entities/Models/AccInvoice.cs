using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AccInvoice
    {
        public long InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public DateTime? PeriodFrom { get; set; }
        public DateTime? PeriodTo { get; set; }
        public int? InvoiceTypeId { get; set; }
        public long? CourierCoId { get; set; }
        public decimal? FacilitationChrgs { get; set; }
        public decimal? FacilitationAmt { get; set; }
        public decimal? ScreenAirlineChrgs { get; set; }
        public decimal? ScreenAirlineAmt { get; set; }
        public decimal? ScreenEicichrgs { get; set; }
        public decimal? ScreenEiciamt { get; set; }
        public decimal? CustomCostRcvrChrgs { get; set; }
        public decimal? CustomCostRcvrAmt { get; set; }
        public decimal? CustomSixtyPayChrgs { get; set; }
        public decimal? CustomSixtyPayAmt { get; set; }
        public decimal? ServiceTaxChrgs { get; set; }
        public decimal? ServiceTaxAmt { get; set; }
        public decimal? PrimaryCessChrgs { get; set; }
        public decimal? PrimaryCessAmt { get; set; }
        public decimal? SecondaryCessChrgs { get; set; }
        public decimal? SecondaryCessAmt { get; set; }
        public decimal? UserAccessArea { get; set; }
        public decimal? UserAccessChrgs { get; set; }
        public decimal? UserAccessAmt { get; set; }
        public decimal? MemberShipFees { get; set; }
        public decimal? EntranceFees { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public string OutstandingStatus { get; set; }
        public string Remarks { get; set; }
        public string TerminalCode { get; set; }
        public int? FinYear { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public decimal? SwachhBharatCessChrgs { get; set; }
        public decimal? SwachhBharatCessAmt { get; set; }
        public decimal? ImportChargesChrgs { get; set; }
        public decimal? ImportChargesAmt { get; set; }
        public string ImportChargesName { get; set; }
        public decimal? ExportChargesChrgs { get; set; }
        public decimal? ExportChargesAmt { get; set; }
        public string ExportChargesName { get; set; }
    }
}
