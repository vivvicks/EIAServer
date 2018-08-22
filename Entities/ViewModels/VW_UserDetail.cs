using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
    public partial class VW_UserDetail
    {
        public long UserMstID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string FatherName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string EmpCode { get; set; }
        public string P1 { get; set; }
        public string P2 { get; set; }
        public string P3 { get; set; }
        public string LoginID { get; set; }
        public long LoginMId { get; set; }
        public string Password { get; set; }
        public string ActiveStatus { get; set; }
        public int ProfileId { get; set; }
        public string ContactPerson { get; set; }
        public string ApplicationName { get; set; }
        public string RPassword { get; set; }
        public string MCAddress { get; set; }
        public string LockStatus { get; set; }
        public string Name { get; set; }
        public string MC_Status { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
