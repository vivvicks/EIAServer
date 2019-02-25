﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICommonMaster
    {
        Task<IEnumerable<MCommonMasterMst>> GetFinantialYear();
        Task<IEnumerable<MCommonMasterMst>> GetCourierType();
        Task<IEnumerable<MCommonMasterMst>> GetMemberType();
    }
}
