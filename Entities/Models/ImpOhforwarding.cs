using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpOhforwarding
    {
        public decimal ForwardingId { get; set; }
        public string ForwardingNo { get; set; }
        public DateTime? ForwardingDate { get; set; }
        public int? ForwardingTime { get; set; }
        public decimal? Form2Id { get; set; }
        public decimal? OnHoldId { get; set; }
        public string MemoNo { get; set; }
        public string IgmreferenceNo { get; set; }
        public string EcmreferenceNo { get; set; }
        public string CustomRepresentative { get; set; }
        public string CourierRepresentative { get; set; }
        public string Charepresentative { get; set; }
        public string ImporterRepresentative { get; set; }
        public string Remarks { get; set; }
        public decimal? InwardWeight { get; set; }
        public string InwardRemarks { get; set; }
        public string InwardCourierRepresentativeName { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string Year { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
