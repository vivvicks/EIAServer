using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
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

        [HttpGet("{id}", Name = "RoleById")]
        public async Task<IActionResult> GetRoleById(Int32 id)
        {
            try
            {
                var Role = await _repo.roleCreation.GetRoleByID(id);
                return Ok(Role);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside GetRoleById action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody]VsecRoleMst vsecRoleMst)
        {
            try
            {
                await _repo.roleCreation.CreateRole(vsecRoleMst);

                return CreatedAtRoute("RoleById", new { id = vsecRoleMst.RoleId }, vsecRoleMst);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside CreateRole action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
        [HttpPut()]
        public async Task<IActionResult> UpdateRole([FromBody]VsecRoleMst vsecRoleMst)
        {
            try
            {
                await _repo.roleCreation.UpdateRole(vsecRoleMst);                

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside UpdateRole action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}