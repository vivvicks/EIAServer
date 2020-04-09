using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers
{
    [Authorize]
    [EnableCors("CorsPolicy")]
    [ApiController]
    [Route("api/Utility")]
    public class UtilityController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public UtilityController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        
        [HttpGet(), Route("GetFinantialYear")]
        public async Task<IActionResult> GetFinantialYear()
        {
            var FinYear = (from FnYear in (await _repository.commonMaster.GetFinantialYear())
                            select new { FnYear.MasterValue1, FnYear.MasterDesc }).ToList();
            return Ok(FinYear);
        }

        [HttpGet(), Route("GetAirlineList")]
        public async Task<IActionResult> GetAirlineList()
        {
            
            var airlineMsts = (from airline in (await _repository.mAirlineMST.GetAirlineList())
                                select new { airline.AirlineCode, airline.AirlineName }).ToList();
            return Ok(airlineMsts);
            
        }

        [HttpGet(), Route("GetCourierType")]
        public async Task<IActionResult> GetCourierType()
        {
            var CourierTypes = (from courierType in (await _repository.commonMaster.GetCourierType())
                                select new { courierType.MasterId, courierType.MasterDesc }).ToList();

            return Ok(CourierTypes);
         
        }

        [HttpGet(), Route("GetMemberType")]
        public async Task<IActionResult> GetMemberType()
        {
            var MemberTypes = (from MemberType in (await _repository.commonMaster.GetMemberType())
                                select new { MemberType.MasterId, MemberType.MasterDesc }).ToList();

            return Ok(MemberTypes);
         
        }

        [HttpGet(), Route("getFlightLst")]
        public async Task<IActionResult> getFlightLst(string terminalCode, string airlineCode, string flightType)
        {
            var flightLst = await _repository.mFlightmasterMst.GetFlightList(terminalCode, airlineCode, flightType);
            return Ok(flightLst);
        }

        [HttpGet(), Route("GetFlightDetails")]
        public IActionResult GetFlightDetails(string FlightNumber, string TerminalCode)
        {
            var flightDetails =  _repository.mFlightmasterMst.GetFlightDetails(FlightNumber, TerminalCode);
            return Ok(flightDetails);
        }

        [HttpGet(), Route("GetCourierLst")]
        public async Task<IActionResult> GetCourierLst(string TerminalCode)
        {
            var courierLst = await _repository.mCouriermst.GetCourierList(TerminalCode);
            return Ok(courierLst);
        }

    }
}