using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers.UserManagement
{
    [Route("api/UserCreation")]
    [ApiController]
    public class UserCreationController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryViewWrapper _repository;

        public UserCreationController(ILoggerManager logger, IRepositoryViewWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet(), Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers(string TerminalCode)
        {
            try
            {
                var users = await _repository.userCreation.GetUserDetails(TerminalCode);

                return Ok(users);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetAllOwners method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}