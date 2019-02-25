﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers
{
    [Route("api/Utility")]
    [ApiController]
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
            try
            {
                var FinYear = (from FnYear in (await _repository.commonMaster.GetFinantialYear())
                              select new { FnYear.MasterValue1, FnYear.MasterDesc }).ToList();

                return Ok(FinYear);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetFinantialYear method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet(), Route("GetAirlineList")]
        public async Task<IActionResult> GetAirlineList()
        {
            try
            {
                var airlineMsts = (from airline in (await _repository.mAirlineMST.GetAirlineList())
                                  select new { airline.AirlineCode,airline.AirlineName }).ToList();

                return Ok(airlineMsts);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAirlineList method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet(), Route("GetCourierType")]
        public async Task<IActionResult> GetCourierType()
        {
            try
            {
                var CourierTypes = (from courierType in (await _repository.commonMaster.GetCourierType())
                                   select new { courierType.MasterId, courierType.MasterDesc }).ToList();

                return Ok(CourierTypes);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetCourierType method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet(), Route("GetMemberType")]
        public async Task<IActionResult> GetMemberType()
        {
            try
            {
                var MemberTypes = (from MemberType in (await _repository.commonMaster.GetMemberType())
                                   select new { MemberType.MasterId, MemberType.MasterDesc }).ToList();

                return Ok(MemberTypes);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetMemberType method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}