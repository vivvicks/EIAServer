using Contracts;
using Entities.Models;
using Entities.StoreProcResults;
using Repository.Extention;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class LoginRepository : RepositoryBase<VSECGetPasswordByUserName>, ILoginRepository
    {

        public LoginRepository(EIA_DEVContext eIA_DEVContext) : base(eIA_DEVContext)
        {
        }


        public IList<result> GetPassword(VSECGetPasswordByUserName vsecGetPasswordByUserName)
        {
            
            return   EIA_DEVContext.LoadStoredProc("proc_VSECGetPasswordByUserName")
                    .WithSqlParam("@LoginID", vsecGetPasswordByUserName.LoginId)
                    .WithSqlParam("@IpAddress", vsecGetPasswordByUserName.IPAddress)
                    .WithSqlParam("@WebSessionID", vsecGetPasswordByUserName.WebsessionID)
                    .WithSqlParam("@Mode", vsecGetPasswordByUserName.Mode)
                    .ExecuteStoredProc<result>(); 
            
        }

        public IList<VSECVerifyUser_Result> ValidateUser(VSECGetPasswordByUserName vsecGetPasswordByUserName)
        {
            return EIA_DEVContext.LoadStoredProc("proc_VSECVerifyUser")
                    .WithSqlParam("@LoginID", vsecGetPasswordByUserName.LoginId)
                    .WithSqlParam("@password",vsecGetPasswordByUserName.Password)
                    .WithSqlParam("@IpAddress", vsecGetPasswordByUserName.IPAddress)
                    .WithSqlParam("@WebSessionID", vsecGetPasswordByUserName.WebsessionID)
                    .WithSqlParam("@CultureID", DBNull.Value)
                    .ExecuteStoredProc<VSECVerifyUser_Result>();
        }
    }
}
