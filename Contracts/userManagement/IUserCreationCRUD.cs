using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.userManagement
{
    public interface IUserCreationCRUD
    {
        Task CreateUser(VW_UserDetail vw_UserDetail);
        Task<long> MaxUserMstID();
    }
}
