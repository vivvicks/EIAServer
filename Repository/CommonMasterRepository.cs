using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CommonMasterRepository : RepositoryBase<MCommonMasterMst>, ICommonMaster
    {

        public CommonMasterRepository(EIA_DEVContext eIA_DEVContext)
           : base(eIA_DEVContext)
        {
        }

        public async Task<IEnumerable<MCommonMasterMst>> GetFinantialYear()
        {
            return await FindByConditionAync(Master => Master.MasterType.Equals("FinYear"));
        }
    }
}
