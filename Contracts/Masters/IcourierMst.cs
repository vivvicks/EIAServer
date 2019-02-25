using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Masters
{
    public interface IcourierMst
    {
        Task<IEnumerable<VWEDT_COURIERMST>> GetCourierDetails(VWEDT_COURIERMST vWEDT_COURIERMST);
    }
}
