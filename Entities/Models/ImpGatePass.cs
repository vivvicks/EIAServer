using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpGatePass
    {
        public decimal GatePassId { get; set; }
        public string GatePassNo { get; set; }
        public DateTime? GatePassDate { get; set; }
        public long? Time { get; set; }
        public decimal? Form2Id { get; set; }
        public decimal? OnHoldId { get; set; }
        public string MemoNo { get; set; }
        public string IgmreferenceNo { get; set; }
        public string EcmreferenceNo { get; set; }
        public DateTime? IssueDateTime { get; set; }
        public string PreventiveOfficer { get; set; }
        public string ClearedBy { get; set; }
        public string Chaname { get; set; }
        public string FinYear { get; set; }
        public string Gptype { get; set; }
        public string FileNo { get; set; }
        public string Ddrno { get; set; }
        public DateTime? Ddrdate { get; set; }
        public decimal? Ddramount { get; set; }
        public string Idfnumber { get; set; }
        public decimal? AssessedValue { get; set; }
        public decimal? DutyFeeAmount { get; set; }
        public string Remarks { get; set; }
        public string ChargesApplicable { get; set; }
        public string ChargesApplicableRemarks { get; set; }
        public decimal? CourierEmpId { get; set; }
        public decimal? WaiveDelayCharges { get; set; }
        public decimal? DelayedCharges { get; set; }
        public decimal? WaiveTdscharges { get; set; }
        public decimal? ServiceTax { get; set; }
        public decimal? RedemptionFine { get; set; }
        public decimal? Personalpenalty { get; set; }
        public int? DelayDays { get; set; }
        public int? Tpctm { get; set; }
        public decimal? Tdsprc { get; set; }
        public decimal? Tdsamount { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
        public decimal? ServiceTaxPerc { get; set; }
        public decimal? SwachhBharatCessAmt { get; set; }
        public decimal? SwachhBharatCessPerc { get; set; }
    }
}
