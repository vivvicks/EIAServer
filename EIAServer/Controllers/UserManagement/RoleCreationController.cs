using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers.UserManagement
{
    [Route("api/RoleCreation")]
    [ApiController]
    [Authorize]
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
            var roles = await _repo.roleCreation.GetRoles();
            return Ok(roles);
            
        }

        [HttpGet("{id}", Name = "RoleById")]
        public async Task<IActionResult> GetRoleById(Int32 id)
        {
            var Role = await _repo.roleCreation.GetRoleByID(id);
            return Ok(Role);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody]VsecRoleMst vsecRoleMst)
        {
            await _repo.roleCreation.CreateRole(vsecRoleMst);
            return CreatedAtRoute("RoleById", new { id = vsecRoleMst.RoleId }, vsecRoleMst);   
        }
        [HttpPut()]
        public async Task<IActionResult> UpdateRole([FromBody]VsecRoleMst vsecRoleMst)
        {
            await _repo.roleCreation.UpdateRole(vsecRoleMst);                
            return NoContent();
        }
    }
}