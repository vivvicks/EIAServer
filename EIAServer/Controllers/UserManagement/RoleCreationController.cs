using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers.UserManagement
{
    [Route("api/RoleCreation")]
    [ApiController]
    public class RoleCreationController : ControllerBase
    {
        private ILoggerManager _logger;        
        private IRepositoryWrapper _repo;

        public RoleCreationController(ILoggerManager logger, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repo = repositoryWrapper;
        }

        [HttpGet(), Route("GetAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            try
            {
                var roles = await _repo.roleCreation.GetRoles();

                return Ok(roles);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAllRoles method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}