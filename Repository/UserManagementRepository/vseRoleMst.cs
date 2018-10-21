using Contracts.userManagement;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task CreateRole(VsecRoleMst vsecRoleMst)
        {
            VsecRoleMst vsecRole = new VsecRoleMst
            {
                ParentRoleId = null,
                RoleSname = vsecRoleMst.RoleSname,
                DisplayName = vsecRoleMst.DisplayName,
                ActiveFlag = vsecRoleMst.ActiveFlag,
                Status = vsecRoleMst.Status,
                McStatus = vsecRoleMst.McStatus,
                CreatedBy = vsecRoleMst.CreatedBy,
                CreatedOn = DateTime.Now,
                UpdatedBy = vsecRoleMst.UpdatedBy,
                UpdatedOn = null,
                LastUpDtBy = vsecRoleMst.LastUpDtBy,
                LastUpDtOn = null
            };
            Create(vsecRole);
            await SaveAsync();
        }

        public async Task<VsecRoleMst> GetRoleByID(int RoleId)
        {
            var Role = await FindByConditionAync(role => role.RoleId.Equals(RoleId));
            return Role.DefaultIfEmpty(new VsecRoleMst()).FirstOrDefault();
        }

        public async Task<IEnumerable<VsecRoleMst>> GetRoles()
        {
            return await FindAllAsync();
        }

        public async Task UpdateRole(VsecRoleMst vsecRoleMst)
        {
            VsecRoleMst vsecRole = new VsecRoleMst
            {
                RoleId = vsecRoleMst.RoleId,
                ParentRoleId = null,
                RoleSname = vsecRoleMst.RoleSname,
                DisplayName = vsecRoleMst.DisplayName,
                ActiveFlag = vsecRoleMst.ActiveFlag,
                Status = vsecRoleMst.Status,
                McStatus = vsecRoleMst.McStatus,
                CreatedBy = vsecRoleMst.CreatedBy,
                CreatedOn = vsecRoleMst.CreatedOn,
                UpdatedBy = vsecRoleMst.UpdatedBy,
                UpdatedOn = DateTime.Now,
                LastUpDtBy = vsecRoleMst.LastUpDtBy,
                LastUpDtOn = DateTime.Now
            };
            Update(vsecRole);
            await SaveAsync();
        }
    }
}
