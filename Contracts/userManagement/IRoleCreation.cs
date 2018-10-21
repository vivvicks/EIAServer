using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.userManagement
{
    public interface IRoleCreation
    {
        Task<IEnumerable<VsecRoleMst>> GetRoles();
        Task CreateRole(VsecRoleMst vsecRoleMst);
        Task UpdateRole(VsecRoleMst vsecRoleMst);
        Task<VsecRoleMst> GetRoleByID(int RoleId);
    }
}
