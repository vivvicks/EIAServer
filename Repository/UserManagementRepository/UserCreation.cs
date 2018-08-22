using Contracts.UserManagement;
using Entities;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserManagementRepository
{
    public class UserCreation : RepositoryBase<VW_UserDetail>, IUserCreation
    {
        public UserCreation(EIA_DEVContext_View eIA_DEVContext_view)
           :base(eIA_DEVContext_view)
        {
        }

        public async Task<IEnumerable<VW_UserDetail>> GetUserDetails(string TerminalCode)
        {
            return await FindByConditionAyncView(user => user.P1 == TerminalCode);
        }
    }
}
