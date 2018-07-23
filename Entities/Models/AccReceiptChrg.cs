using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AccReceiptChrg
    {
        public decimal ReceiptId { get; set; }
        public int? ReceiptChrgType { get; set; }
        public string Igmnumber { get; set; }
        public decimal? FacilitationChrgs { get; set; }
        public decimal? FacilitationAmt { get; set; }
        public decimal? ScreenAirlineChrgs { get; set; }
        public decimal? ScreenAirlineAmt { get; set; }
        public decimal? ScreenEicichrgs { get; set; }
        public decimal? ScreenEiciamt { get; set; }
        public decimal? CustomCostRcvrChrgs { get; set; }
        public decimal? CustomCostRcvrAmt { get; set; }
        public decimal? CustomSixtyPayChrgs { get; set; }
        public decimal? CustomSixtyPayAmt { get; set; }
        public decimal? ServiceTaxChrgs { get; set; }
        public decimal? ServiceTaxAmt { get; set; }
        public decimal? PrimaryCessChrgs { get; set; }
        public decimal? PrimaryCessAmt { get; set; }
        public decimal? SecondaryCessChrgs { get; set; }
        public decimal? SecondaryCessAmt { get; set; }
        public decimal? Weight { get; set; }
    }
}
