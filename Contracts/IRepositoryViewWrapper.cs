using Contracts.Masters;
using Contracts.UserManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryViewWrapper
    {
        IUserCreation userCreation { get; }
        IcourierMst courierMst { get; }
    }
}
