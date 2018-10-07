using Contracts.userManagement;
using Entities.Models;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.UserManagementRepository
{
    public class UserCreationCRUD : RepositoryBase<VsecUserMst>, IUserCreationCRUD
    {
        public UserCreationCRUD(EIA_DEVContext eIA_DEVContext)
         : base(eIA_DEVContext)
        {
        }

        public async Task CreateUser(VW_UserDetail vw_userdetail)
        {
            long UserMstId = MaxUserMstID().Result;

            VsecUserMst vsec_user_mst = new VsecUserMst
            {
                UserMstId = UserMstId + 1, 
                FirstName = vw_userdetail.FirstName,
                MiddleName = vw_userdetail.MiddleName,
                LastName = vw_userdetail.LastName,
                FatherName = vw_userdetail.FatherName,
                Dob = vw_userdetail.DOB,
                Gender = vw_userdetail.Gender,
                Email = vw_userdetail.Email,
                Address1 = vw_userdetail.Address1,
                Address2 = vw_userdetail.Address2,
                Address3 = vw_userdetail.Address3,
                ContactNo = vw_userdetail.ContactNo,
                Status = vw_userdetail.Status,
                McStatus = vw_userdetail.Status,
                CreatedBy = vw_userdetail.CreatedBy,
                CreatedOn = DateTime.Now,
                P1 = vw_userdetail.P1
            };
            Create(vsec_user_mst);
            await SaveAsync();
        }

        public async Task<long> MaxUserMstID()
        {
            return (await FindAllAsync()).Max(p => p.UserMstId);
        }
    }
}
