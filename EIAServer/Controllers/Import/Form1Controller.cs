using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers.Import
{
    [Route("api/Form1")]
    [ApiController]
    [Authorize]
    public class Form1Controller : ControllerBase
    {
        private ILoggerManager _logger;        
        private IRepositoryWrapper _repo;

        public Form1Controller(ILoggerManager logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;            
            _repo = repositoryWrapper;
        }

        [HttpGet(), Route("GetIGMDetails")]
        public IActionResult GetIGMDetails(string IGMNumber, string MAWBNumber, string TerminalCode)
        {
            var igmDetails = _repo.mFlightmasterMst.GetIGMDetails(IGMNumber, MAWBNumber, TerminalCode);
            return Ok(igmDetails);
        }
    }
}