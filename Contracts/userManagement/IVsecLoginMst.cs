using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.userManagement
{
    public interface IVsecLoginMst
    {
        Task CreatLogin(VW_UserDetail vw_UserDetail);
        Task UpdateLogin(VW_UserDetail vw_UserDetail);
    }
}
