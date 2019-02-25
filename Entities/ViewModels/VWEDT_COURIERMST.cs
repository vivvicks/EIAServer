﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ViewModels
{
    public class VWEDT_COURIERMST
    {
        public long CourierCoId { get; set; }
        public string CourierCoCode { get; set; }
        public string CourierCoRegistrationNumber { get; set; }
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
        public Nullable<long> CourierCoPinCode { get; set; }
        public string CourierType { get; set; }
        public string MemberTypeId { get; set; }
        public string TerminalCode { get; set; }
        public string Status { get; set; }
        public string MC_Status { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public Nullable<System.DateTime> LastUpDtOn { get; set; }
        public Nullable<System.DateTime> CourierCoRegistrationExpiryDt { get; set; }
    }
}
