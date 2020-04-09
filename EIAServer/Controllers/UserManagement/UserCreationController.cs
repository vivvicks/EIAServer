using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace EIAServer.Controllers.UserManagement
{
    [Route("api/UserCreation")]
    [ApiController]
    [Authorize]
    public class UserCreationController : ControllerBase
    {
        private ILoggerManager _logger;
        private IRepositoryViewWrapper _repository;
        private IRepositoryWrapper _repo;

        public UserCreationController(ILoggerManager logger, IRepositoryViewWrapper repository, IRepositoryWrapper repositoryWrapper)
        {
            _logger = logger;
            _repository = repository;
            _repo = repositoryWrapper;
        }

        [HttpGet(), Route("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers(string TerminalCode)
        {
            var users = await _repository.userCreation.GetUserDetails(TerminalCode);
            return Ok(users);
        }

        [HttpGet("{id}", Name = "UserById")]
        public async Task<IActionResult> GetUserById(long id)
        {
                var User = await _repository.userCreation.GetUserByID(id);
                return Ok(User);
        }


        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody]VW_UserDetail vw_UserDetail)
        {
            var Transaction = _repo.BeginTrainsaction();
            try
            {
                await _repo.userCreationCRUD.CreateUser(vw_UserDetail);
                vw_UserDetail.UserMstID = _repo.userCreationCRUD.MaxUserMstID().Result;
                await _repo.vsecLoginMst.CreatLogin(vw_UserDetail);

                Transaction.Commit();

                return CreatedAtRoute("UserById", new { id = vw_UserDetail.UserMstID }, vw_UserDetail);
            }
            catch(Exception ex)
            {
                Transaction.Rollback();
                _logger.LogError($"Something went wrong inside CreateUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
            finally
            {
                Transaction.Dispose();
            }
        }

        [HttpPut()]
        public async Task<IActionResult> UpdateUser([FromBody]VW_UserDetail vw_UserDetail)
        {
            var Transaction = _repo.BeginTrainsaction();
            try
            {
                await _repo.userCreationCRUD.UpdateUser(vw_UserDetail);
                await _repo.vsecLoginMst.UpdateLogin(vw_UserDetail);

                Transaction.Commit();

                return NoContent();
            }
            catch (Exception ex)
            {
                Transaction.Rollback();
                _logger.LogError($"Something went wrong inside UpdateUser action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
            finally
            {
                Transaction.Dispose();
            }
        }
    }
}