using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MTerminalMst
    {
        public string TerminalCode { get; set; }
        public string TerminalName { get; set; }
        public string TerminalMode { get; set; }
        public string Roaddress1 { get; set; }
        public string Roaddress2 { get; set; }
        public string Roaddress3 { get; set; }
        public string Roaddress4 { get; set; }
        public string TermAddress1 { get; set; }
        public string TermAddress2 { get; set; }
        public string TermAddress3 { get; set; }
        public string TermAddress4 { get; set; }
        public string ServiceTaxRegnNo { get; set; }
        public string WebSiteName { get; set; }
        public string PanNo { get; set; }
        public decimal? ExpFacilitationFee { get; set; }
        public string ExpFacilitationAccount { get; set; }
        public decimal? ExpXrayChrgAirline { get; set; }
        public decimal? ExpXrayChrgEici { get; set; }
        public string ExpXrayChrgAccount { get; set; }
        public decimal? ExpCustomCostChrg { get; set; }
        public string ExpCustomCostAccount { get; set; }
        public decimal? ExpCustomSixtyPayChrg { get; set; }
        public string ExpCustomSixtyPayAccount { get; set; }
        public decimal? ImpFacilitationFee { get; set; }
        public string ImpFacilatationAccount { get; set; }
        public decimal? ImpCustomCostChrg { get; set; }
        public string ImpCustomCostAccount { get; set; }
        public decimal? ImpCustomSixtyPayChrg { get; set; }
        public string ImpCustomSixtyPayAccount { get; set; }
        public decimal? ServiceTaxPerc { get; set; }
        public string ServiceTaxAccount { get; set; }
        public decimal? PrimaryEduCessPerc { get; set; }
        public decimal? SecondaryEduCessPerc { get; set; }
        public string MemberShipFeesAccount { get; set; }
        public string UserAccessFeesAccount { get; set; }
        public string ExportCashAccount { get; set; }
        public string ExportTdsaccount { get; set; }
        public string ImportCashAccount { get; set; }
        public string ImportTdsaccount { get; set; }
        public string FacilitationBankCreditAccount { get; set; }
        public string DetentionFeesAccount { get; set; }
        public string DetentionBankCreditAccount { get; set; }
        public string DetentionCashAccount { get; set; }
        public string DetentionTdsaccount { get; set; }
        public string DetentionServiceTaxAccount { get; set; }
        public string SaleLotAutoMode { get; set; }
        public string ReportPreview { get; set; }
        public string OperationalManager { get; set; }
        public string Optional1 { get; set; }
        public string Optional2 { get; set; }
        public string Optional3 { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public string InvoiceNote { get; set; }
        public string ActiveStatus { get; set; }
        public decimal? SwachhBharatCess { get; set; }
        public decimal? ImportChargesPerc { get; set; }
        public string ImportChargesAccount { get; set; }
        public string ImportChargesName { get; set; }
        public decimal? ExportChargesPerc { get; set; }
        public string ExportChargesAccount { get; set; }
        public string ExportChargesName { get; set; }
    }
}
