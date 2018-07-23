using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MCourierMst
    {
        public long CourierCoId { get; set; }
        public string CourierCoCode { get; set; }
        public string CourierCoRegistrationNumber { get; set; }
        public DateTime? CourierCoRegistrationExpiryDt { get; set; }
        public string CourierCoName { get; set; }
        public string CourierCoTallyName { get; set; }
        public string CourierCoMigratedName { get; set; }
        public string ContactPerson { get; set; }
        public string CourierEmail { get; set; }
        public string CourierContact { get; set; }
        public string CourierCoAddr1 { get; set; }
        public string CourierCoAddr2 { get; set; }
        public string CourierCoState { get; set; }
        public string CourierCoCity { get; set; }
        public long? CourierCoPinCode { get; set; }
        public int? CourierType { get; set; }
        public int? MemberTypeId { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
