using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.StoreProcResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EIAServer.Controllers
{
    [Route("api/Login")]    
    public class LoginController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;

        public LoginController(ILoggerManager logger, IRepositoryWrapper repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost(), Route("login")]
        public IActionResult Login([FromBody]VSECGetPasswordByUserName vsecGetPasswordByUserName)
        {

            if (vsecGetPasswordByUserName == null)
            {
                return BadRequest("Invalid client request");
            }
            
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                IList<result> Password = _repository.login.GetPassword(vsecGetPasswordByUserName);
                if(Password?.Any()??false)
                {
                    string inputPwd = vsecGetPasswordByUserName.Password;
                    string dbPwd = Password[0].Password;
                    string convertedPwd = dbPwd + Convert.ToString(vsecGetPasswordByUserName.RandomNumber);

                    string md5Pwd = HashString(convertedPwd);

                    if(md5Pwd.ToUpper() == inputPwd.ToUpper())
                    {

                    }

                }

                          

                return Ok(Password);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Some error in the Login method: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

        public static string HashString(string inputString)
        {
            MD5 algorithm = MD5.Create();
            byte[] data = algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            string sh1 = "";
            for (int i = 0; i < data.Length; i++)
            {
                sh1 += data[i].ToString("x2").ToUpperInvariant();
            }
            return sh1;
        }
    }
}