using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Contracts;
using Entities.StoreProcResults;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

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
                if (Password?.Any()??false)
                {
                    string inputPwd = vsecGetPasswordByUserName.Password;
                    string dbPwd = Password[0].Password;
                    string convertedPwd = dbPwd + Convert.ToString(vsecGetPasswordByUserName.RandomNumber);

                    string md5Pwd = HashString(convertedPwd);

                    if(md5Pwd.ToUpper() == inputPwd.ToUpper())
                    {
                        vsecGetPasswordByUserName.Password = dbPwd;
                        IList<VSECVerifyUser_Result> userInfo = _repository.login.ValidateUser(vsecGetPasswordByUserName);
                        if (userInfo.Any(c => c.ValidUser == "Y"))
                        {
                            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));

                            var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

                            var claims = new List<Claim>
                                {
                                    new Claim(ClaimTypes.Name, vsecGetPasswordByUserName.LoginId),
                                    new Claim(ClaimTypes.Role, "Admin")
                                };

                            var tokeOptions = new JwtSecurityToken(
                                issuer: "http://localhost:5000",
                                audience: "http://localhost:5000",
                                claims: claims,
                                expires: DateTime.Now.AddMinutes(5),
                                signingCredentials: signinCredentials
                            );

                            var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);

                            return Ok(new { UserInfo = userInfo, TokenString = tokenString });
                        }
                        else
                        {
                            return Unauthorized();
                        }
                    }
                    else
                    {
                        return Unauthorized();
                    }

                }
                else
                {
                    return Unauthorized();
                }
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
            string md5 = "";
            for (int i = 0; i < data.Length; i++)
            {
                md5 += data[i].ToString("x2").ToUpperInvariant();
            }
            return md5;
        }
    }
}