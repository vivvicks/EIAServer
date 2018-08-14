﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ILoginRepository login { get; }
        ICommonMasterRepository commonMasterRepository { get; }
    }
}
