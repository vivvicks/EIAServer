using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpOnHoldMemo
    {
        public decimal OnHoldId { get; set; }
        public string MemoNo { get; set; }
        public decimal? Form2Id { get; set; }
        public int? Form2Type { get; set; }
        public string IgmreferenceNo { get; set; }
        public string EcmreferenceNo { get; set; }
        public string Hawbno { get; set; }
        public int? NoofPkgs { get; set; }
        public int? NoofShps { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? NetWeight { get; set; }
        public string ImportExportCode { get; set; }
        public string IecsourceCode { get; set; }
        public string SpecialRequest { get; set; }
        public int? OnHoldReason { get; set; }
        public string ReasonDescription { get; set; }
        public string WarehouseLocation { get; set; }
        public string WarehouseRemarks { get; set; }
        public string WarehouseIdentification { get; set; }
        public string CourierStaffName { get; set; }
        public string CourierStaffRemarks { get; set; }
        public string ConsigneeAddress { get; set; }
        public string ConsigneePin { get; set; }
        public int? OnHoldTypeId { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public string MemoUpdatedBy { get; set; }
        public DateTime? MemoUpdatedOn { get; set; }
        public string TerminalCode { get; set; }
        public string FinYear { get; set; }
        public string ConsigneeName { get; set; }
        public string ItemDescription { get; set; }
        public decimal? Value { get; set; }
        public DateTime? OnHoldDate { get; set; }
        public long? OnHoldTime { get; set; }
        public string AucDescription { get; set; }
        public decimal? AssessedValue1 { get; set; }
        public decimal? AssessedValue2 { get; set; }
        public string AssessedValue1Type { get; set; }
        public string AssessedValue2Type { get; set; }
        public string ConsigneeEmailId { get; set; }
        public string ConsigneeContactNo { get; set; }
        public decimal? AucListId { get; set; }
        public DateTime? Notification1SentOn { get; set; }
        public DateTime? Notification2SentOn { get; set; }
        public string Notification1SentRemarks { get; set; }
        public string Notification2SentRemarks { get; set; }
        public string Drgroup { get; set; }
        public string ReasonType { get; set; }
        public string ThokaNo { get; set; }
        public int? VersionNo { get; set; }
    }
}
