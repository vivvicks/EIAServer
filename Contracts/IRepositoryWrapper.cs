using Contracts.UserManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ILoginRepository login { get; }
        ICommonMaster commonMaster { get; }
        IMAirlineMST mAirlineMST { get; }
    }
}
