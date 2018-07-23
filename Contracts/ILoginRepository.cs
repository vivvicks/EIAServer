using Entities.StoreProcResults;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ILoginRepository
    {
        IList<VSECGetPasswordByUserName> GetPassword(string LoginId,string IPAddress,string WebsessionID, string Mode);
    }
}
