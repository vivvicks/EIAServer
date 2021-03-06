﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers.Masters
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CourierDetailsController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryViewWrapper _repository;
        private IRepositoryWrapper _repo;

        public CourierDetailsController(ILoggerManager logger, IRepositoryViewWrapper repository, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repository = repository;
            _repo = repositoryWrapper;
        }

        [HttpGet(), Route("GetAllCouriers")]
        public async Task<IActionResult> GetAllCouriers([FromQuery]VWEDT_COURIERMST vWEDT_COURIERMST)
        {
            var users = await _repository.courierMst.GetCourierDetails(vWEDT_COURIERMST);
            return Ok(users);
        }
    }
}