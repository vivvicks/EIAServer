using Contracts;
using Contracts.Masters;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MCouriermasterMSTRepository : RepositoryBase<MCourierMst>, IMCouriermst
    {
        public MCouriermasterMSTRepository(EIA_DEVContext eIA_DEVContext)
        : base(eIA_DEVContext)
        {

        }

        public async Task<IEnumerable<MCourierMst>> GetCourierList(string TerminalCode)
        {
            return await FindByConditionAync(courier => courier.TerminalCode.Equals(TerminalCode) && courier.Status == "A");
        }
    }
}
