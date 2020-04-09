using Entities.Models;
using Entities.StoreProcResults;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMFlightmasterMST
    {
        Task<IEnumerable<MFlightmasterMst>> GetFlightList(string TerminalCode, string AirlineCode, string FlightType);
        IList<GetFlightDetails> GetFlightDetails(string FlightNumber, string TerminalCode);
        IList<GetForm1CheckStatus_result> GetIGMDetails(string IGMNumber, string MAWBNumber, string TerminalCode);
    }
}
