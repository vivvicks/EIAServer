using Entities.StoreProcResults;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ILoginRepository
    {
        IList<result> GetPassword(VSECGetPasswordByUserName vsecGetPasswordByUserName);
        IList<VSECVerifyUser_Result> ValidateUser(VSECGetPasswordByUserName vsecGetPasswordByUserName);
    }
}
