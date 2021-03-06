﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.StoreProcResults
{
    public class VSECVerifyUser_Result
    {
        public string ValidUser { get; set; }
        public string ValidPwd { get; set; }
        public Nullable<long> UserMstID { get; set; }
        public string UserName { get; set; }
        public short RoleID { get; set; }
        public string RoleSName { get; set; }
        public string RoleDName { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public string AppPath { get; set; }
        public string LastPasswordChangeDate { get; set; }
        public string LoginStatus { get; set; }
        public int CultureID { get; set; }
        public string LoginID { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> officeID { get; set; }
        public string TerminalCode { get; set; }
        public string FinancialYear { get; set; }
        public string UserTypeEICI { get; set; }
        public string AirlineCode { get; set; }
        public Nullable<decimal> ServiceTaxPerc { get; set; }
        public Nullable<decimal> PrimaryEduCessPerc { get; set; }
        public Nullable<decimal> SecondaryEduCessPerc { get; set; }
        public string SaleLotAutoMode { get; set; }
        public string ReportPreview { get; set; }
        public string ValidGracePeriod { get; set; }
        public Nullable<int> DaysLeft { get; set; }
        public string Period { get; set; }
        public Nullable<int> PasswordRetry { get; set; }
        public Nullable<int> PwdRetryCount { get; set; }
        public string TokenString { get; set; }

    }
}
