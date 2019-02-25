using Contracts.Masters;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Masters
{
    public class CourierDetails : RepositoryBase<VWEDT_COURIERMST>, IcourierMst
    {
        public CourierDetails(EIA_DEVContext_View eIA_DEVContext_view)
          : base(eIA_DEVContext_view)
        {
        }

        public async Task<IEnumerable<VWEDT_COURIERMST>> GetCourierDetails(VWEDT_COURIERMST vWEDT_COURIERMST)
        {
            IEnumerable<VWEDT_COURIERMST> query = await FindByConditionAyncView(courier => courier.TerminalCode.Equals(vWEDT_COURIERMST.TerminalCode));

            if (vWEDT_COURIERMST.CourierCoName != "")
                query = query.Where(p => p.CourierCoName.Contains(vWEDT_COURIERMST.CourierCoName));

            if (vWEDT_COURIERMST.CourierCoCode != "")
                query = query.Where(p => p.CourierCoCode.Contains(vWEDT_COURIERMST.CourierCoCode));

            if (vWEDT_COURIERMST.CourierType != "")
                query = query.Where(p => p.CourierType == vWEDT_COURIERMST.CourierType);

            if (vWEDT_COURIERMST.MemberTypeId != "")
                query = query.Where(p => p.MemberTypeId == vWEDT_COURIERMST.MemberTypeId);

            return query;
        }
    }
}
