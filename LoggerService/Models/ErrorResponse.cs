using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerService.Models
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string ErrorMessage{ get; set; }
    }
}
