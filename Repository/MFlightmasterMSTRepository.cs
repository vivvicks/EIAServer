using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MFlightmasterMSTRepository : RepositoryBase<MFlightmasterMst>, IMFlightmasterMST
    {
        public MFlightmasterMSTRepository(EIA_DEVContext eIA_DEVContext)
         : base(eIA_DEVContext)
        {

        }

        public async Task<IEnumerable<MFlightmasterMst>> GetFlightList(string TerminalCode, string AirlineCode, string FlightType)
        {
            return await FindByConditionAync(flight => flight.TerminalCode.Equals(TerminalCode) && flight.AirlineCode.Contains(AirlineCode ?? string.Empty) && flight.FlightType.Equals(FlightType));
        }
    }
}
