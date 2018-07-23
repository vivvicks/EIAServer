using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MCourierEmpMst
    {
        public long CourierEmpId { get; set; }
        public string CourierEmpCode { get; set; }
        public string CourierEmpName { get; set; }
        public long? CourierCoId { get; set; }
        public string TypeofId { get; set; }
        public string Idnos { get; set; }
        public string PassNo { get; set; }
        public string IssuedBy { get; set; }
        public string AuthoriseforGp { get; set; }
        public string AuthoriseforBoe { get; set; }
        public string AuthoriseforSecurity { get; set; }
        public string StaffAddress { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string McStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
