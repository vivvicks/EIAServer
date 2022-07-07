﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.StoreProcResults
{
    public class GetForm1CheckStatus_result
    {
        public string FlightNumber { get; set; }
        public string DateOfArrival { get; set; }
        public int TimeOfArrival { get; set; }
        public string IGMNo { get; set; }
        public string IGMDate { get; set; }
        public string FormIMAWBNo { get; set; }
        public string FormIIMAWBNo { get; set; }
        public string CourierCompanyName { get; set; }
        public int Form1ActualNoofBags { get; set; }
        public int Form1ActualNoofPackages { get; set; }
        public int Form1ActualNoofShps { get; set; }
        public decimal Form1ActualWeight { get; set; }
        public int Form1NoofBags { get; set; }
        public int Form2NoofBags { get; set; }
        public int Form1NoofShps { get; set; }
        public int Form2NoofShps { get; set; }
        public int Form1NoofPkgs { get; set; }
        public int Form2NoofPkgs { get; set; }
        public decimal Form1Weight { get; set; }
        public decimal Form2Weight { get; set; }

    }
}