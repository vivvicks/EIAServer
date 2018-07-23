using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class ImpForm2
    {
        public decimal Form2Id { get; set; }
        public string Form2No { get; set; }
        public string IgmreferenceNo { get; set; }
        public DateTime? IgmreferenceDate { get; set; }
        public string EcmreferenceDocNo { get; set; }
        public DateTime? EcmreferenceDocDate { get; set; }
        public decimal? EcmreferenceDocManifestWt { get; set; }
        public string EcmreferenceNonDocNo { get; set; }
        public DateTime? EcmreferenceNonDocDate { get; set; }
        public decimal? EcmreferenceNonDocManifestWt { get; set; }
        public string ThokaNo { get; set; }
        public string Mawbno { get; set; }
        public long? CourierCoId { get; set; }
        public long? AirlineId { get; set; }
        public string FlightNumber { get; set; }
        public string AirportofArrival { get; set; }
        public string AirportofShipment { get; set; }
        public string CountryofExportation { get; set; }
        public DateTime? ActualDateofArrival { get; set; }
        public int? ActualTimeofArrival { get; set; }
        public decimal? InvoiceId { get; set; }
        public string TerminalCode { get; set; }
        public string FinYear { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
        public int? VersionNo { get; set; }
    }
}
