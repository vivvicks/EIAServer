using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMCouriermst
    {
        Task<IEnumerable<MCourierMst>> GetCourierList(string TerminalCode);
    }
}
