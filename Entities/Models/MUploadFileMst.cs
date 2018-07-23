using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class MUploadFileMst
    {
        public long FileId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Module { get; set; }
        public string TransactionId { get; set; }
        public string TerminalCode { get; set; }
        public string FinantcialYear { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string LastUpDtBy { get; set; }
        public DateTime? LastUpDtOn { get; set; }
    }
}
