using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class AccInvoiceDtl
    {
        public long InvoiceDtlId { get; set; }
        public decimal? InvoiceId { get; set; }
        public long? Form2Id { get; set; }
        public string IgmreferenceNo { get; set; }
        public string Mawbno { get; set; }
        public long? NumberofBags { get; set; }
        public long? NumberofPkgs { get; set; }
        public string NumberofShps { get; set; }
        public decimal? GrossWeight { get; set; }
        public string FlightNumber { get; set; }
        public DateTime? ActualDateofArrival { get; set; }
        public decimal? AirlineWeight { get; set; }
        public decimal? Eiciweight { get; set; }
    }
}
