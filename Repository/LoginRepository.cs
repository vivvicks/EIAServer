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
    public class LoginRepository : ILoginRepository
    {

        public LoginRepository(EIA_DEVContext eIA_DEVContext)
        {
        }


        public async Task<IList<VSECGetPasswordByUserName>> GetPassword(string LoginId, string IPAddress, string WebsessionID, string Mode)
        {
            using (var context = new EIA_DEVContext())
            {
                return await Task.FromResult((IList<VSECGetPasswordByUserName>)context.LoadStoredProc("proc_VSECGetPasswordByUserName")
                     .WithSqlParam("@LoginID", LoginId)
                     .WithSqlParam("@IpAddress", IPAddress)
                     .WithSqlParam("@WebSessionID", WebsessionID)
                     .WithSqlParam("@Mode", Mode)
                     .ExecuteStoredProc<VSECGetPasswordByUserName>()); 
            }
        }
    }
}
