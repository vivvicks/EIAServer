using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MAirlineMSTRepository : RepositoryBase<MAirlineMst>, IMAirlineMST
    {
        public MAirlineMSTRepository(EIA_DEVContext eIA_DEVContext)
          : base(eIA_DEVContext)
        {
        }

        public async Task<IEnumerable<MAirlineMst>> GetAirlineList()
        {
            return await FindAllAsync();
        }
    }
}
