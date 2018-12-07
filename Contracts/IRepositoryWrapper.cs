using Contracts.userManagement;
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
        IUserCreationCRUD userCreationCRUD { get; }
        IDatabaseTransaction BeginTrainsaction();
        IVsecLoginMst vsecLoginMst { get; }
        IRoleCreation roleCreation { get; }
        IVsecUserRoleMap vsecUserRoleMap { get; }
    }
}
