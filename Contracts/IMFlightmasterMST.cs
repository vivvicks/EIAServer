using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMFlightmasterMST
    {
        Task<IEnumerable<MFlightmasterMst>> GetFlightList(string TerminalCode, string AirlineCode, string FlightType);
    }
}
