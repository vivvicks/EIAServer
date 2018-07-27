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
    }
}
