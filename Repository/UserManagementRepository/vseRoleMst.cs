using Contracts.userManagement;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserManagementRepository
{
    public class vseRoleMst : RepositoryBase<VsecRoleMst>, IRoleCreation
    {
        public vseRoleMst(EIA_DEVContext eIA_DEVContext)
        : base(eIA_DEVContext)
        {
        }

        public async Task<IEnumerable<VsecRoleMst>> GetRoles()
        {
            return await FindAllAsync();
        }
    }
}
