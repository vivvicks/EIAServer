using System;
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


        [HttpGet(), Route("GetFinaltialYear")]
        public async Task<IActionResult> GetFinaltialYear()
        {
            try
            {
                var FinYear = await _repository.commonMasterRepository.GetFinaltialYear();

                return Ok(FinYear);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetFinaltialYear method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}