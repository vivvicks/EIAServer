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
    [Route("api/UserRoleMap")]
    [ApiController]
    public class UserRoleMapController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryViewWrapper _repository;
        private IRepositoryWrapper _repo;

        public UserRoleMapController(ILoggerManager logger, IRepositoryViewWrapper repository, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repository = repository;
            _repo = repositoryWrapper;
        }

        [HttpGet(), Route("GetRoleMapUsers")]
        public async Task<IActionResult> GetRoleMapUsers(int roleID, string Status, string TerminalCode)
        {
            try
            {

                var usesDetails = await _repository.userCreation.GetUserDetails(TerminalCode);


                if (Status == "Allocated")
                {
                    var mappedRoles = await _repo.vsecUserRoleMap.GetUsersByRoleID(roleID);

                    var RolMappedList = (from MapRoles in mappedRoles
                                         join users in usesDetails on MapRoles.LoginMid equals users.LoginMId
                                         where MapRoles.RoleId == roleID
                                         select users
                                         ).ToList();

                    return Ok(RolMappedList);
                }
                else if (Status == "Available")
                {
                    var mappedRoles = await _repo.vsecUserRoleMap.GetUsersOtherThanRoleID(roleID);

                    var RolMappedList = (from MapRoles in mappedRoles
                                         join users in usesDetails on MapRoles.LoginMid equals users.LoginMId
                                         select users
                                     ).Distinct().ToList();

                    return Ok(RolMappedList);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the GetRoleMapUsers method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AllocateDeallocateRoles(IEnumerable<VsecUserRoleMap> vsecUserRoleMap)
        {
            try
            {   
                await _repo.vsecUserRoleMap.CreateDeleteRoleMapping(vsecUserRoleMap);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the AllocateRoles method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}