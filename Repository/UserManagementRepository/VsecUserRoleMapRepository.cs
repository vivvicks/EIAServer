using Contracts.UserManagement;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserManagementRepository
{
    public class VsecUserRoleMapRepository : RepositoryBase<VsecUserRoleMap>, IVsecUserRoleMap
    {
        public VsecUserRoleMapRepository(EIA_DEVContext eIA_DEVContext)
       : base(eIA_DEVContext)
        {
        }

        public async Task CreateDeleteRoleMapping(IEnumerable<VsecUserRoleMap> arrvsecUserRoleMap)
        {
            foreach (var item in arrvsecUserRoleMap)
            {

                VsecUserRoleMap vsecUserRoleMap = new VsecUserRoleMap();

                if(item.Status == "Y")
                { 
                    vsecUserRoleMap.LoginMid = item.LoginMid;
                    vsecUserRoleMap.RoleId = item.RoleId;
                    vsecUserRoleMap.Status = item.Status;
                    vsecUserRoleMap.CreatedBy = item.CreatedBy;
                    vsecUserRoleMap.CreatedOn = DateTime.Now;
                    Create(vsecUserRoleMap);
                }
                else if(item.Status == "N")
                {
                    var DelvsecUserRoleMap = await GetRoleMapdetails(item.RoleId, item.LoginMid);
                    Delete(DelvsecUserRoleMap);
                }
                await SaveAsync();
            }
        }

        public async Task<VsecUserRoleMap> GetRoleMapdetails(int? RoleId, long LoginMid)
        {
            var rolemapdetails = await FindByConditionAync(rolemap => rolemap.RoleId.Equals(RoleId) && rolemap.LoginMid.Equals(LoginMid));
            return rolemapdetails.DefaultIfEmpty(new VsecUserRoleMap())
                   .FirstOrDefault();
        }

        public async Task<IEnumerable<VsecUserRoleMap>> GetUsersByRoleID(int RoleId)
        {
            return await FindByConditionAync(rolemap => rolemap.RoleId.Equals(RoleId));
        }

        public async Task<IEnumerable<VsecUserRoleMap>> GetUsersOtherThanRoleID(int RoleId)
        {
            return await FindByConditionAync(rolemap => rolemap.RoleId != RoleId);
        }
    }
}
