using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.StoreProcResults
{
    public class VSECGetPasswordByUserName
    {
        public string LoginId { get; set; }
        public string Password { get; set; }
        public string IPAddress { get; set; }
        public string WebsessionID { get; set; }
        public string Mode { get; set; }
        public int RandomNumber { get; set; }
    }

    public class result
    {
        public string Password { get; set; }
    }
}
