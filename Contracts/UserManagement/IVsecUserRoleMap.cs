using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts.UserManagement
{
    public interface IVsecUserRoleMap
    {
        Task<IEnumerable<VsecUserRoleMap>> GetUsersByRoleID(int RoleId);
        Task<IEnumerable<VsecUserRoleMap>> GetUsersOtherThanRoleID(int RoleId);
        Task<VsecUserRoleMap> GetRoleMapdetails(int? RoleId, long LoginMid);
        Task CreateDeleteRoleMapping(IEnumerable<VsecUserRoleMap> vsecUserRoleMap);
    }
}
