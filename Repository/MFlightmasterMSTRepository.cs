using Contracts;
using Entities.Models;
using Entities.StoreProcResults;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Repository.Extention;


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

        public IList<GetFlightDetails> GetFlightDetails(string FlightNumber, string TerminalCode)
        {
            return  EIA_DEVContext.LoadStoredProc("GetFlightDetails")
                    .WithSqlParam("@FlightNumber", FlightNumber)
                    .WithSqlParam("@TerminalCode", TerminalCode)                    
                    .ExecuteStoredProc<GetFlightDetails>();
        }

        public IList<GetForm1CheckStatus_result> GetIGMDetails(string IGMNumber, string MAWBNumber, string TerminalCode)
        {
            return EIA_DEVContext.LoadStoredProc("GetForm1CheckStatus")
                   .WithSqlParam("@IGMNumber", IGMNumber)
                   .WithSqlParam("@MAWBNumber", MAWBNumber)
                   .WithSqlParam("@TerminalCode", TerminalCode)
                   .ExecuteStoredProc<GetForm1CheckStatus_result>();
        }
    }
}
