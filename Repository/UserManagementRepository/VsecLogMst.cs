using Contracts.userManagement;
using Entities.Models;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserManagementRepository
{
    public class VsecLogMst : RepositoryBase<VsecLoginMst>, IVsecLoginMst
    {
        public VsecLogMst(EIA_DEVContext eIA_DEVContext)
        : base(eIA_DEVContext)
        {
        }

        public async Task CreatLogin(VW_UserDetail vw_userdetail)
        {
            VsecLoginMst vsecLoginMst = new VsecLoginMst
            {
                LoginMid = 0,
                LoginId = vw_userdetail.LoginID,
                ProfileId = vw_userdetail.ProfileId,
                ActiveStatus = vw_userdetail.Status,
                Password = vw_userdetail.RPassword,
                CreatedBy = vw_userdetail.CreatedBy,
                CreatedOn = DateTime.Now
            };
            Create(vsecLoginMst);
            await SaveAsync();
        }

        public async Task UpdateLogin(VW_UserDetail vw_userdetail)
        {
            VsecLoginMst vsecLoginMst = new VsecLoginMst
            {
                LoginMid = vw_userdetail.LoginMId,
                LoginId = vw_userdetail.LoginID,
                ProfileId = vw_userdetail.ProfileId,
                ActiveStatus = vw_userdetail.Status,
                Password = vw_userdetail.RPassword,
                CreatedBy = vw_userdetail.CreatedBy,
                CreatedOn = DateTime.Now
            };
            Update(vsecLoginMst);
            await SaveAsync();
        }
    }
}
