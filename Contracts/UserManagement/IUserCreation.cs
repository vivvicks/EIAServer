using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.UserManagement
{
    public interface IUserCreation
    {
        Task<IEnumerable<VW_UserDetail>> GetUserDetails(string TerminalCode);
    }
}
