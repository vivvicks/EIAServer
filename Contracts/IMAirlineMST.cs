﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IMAirlineMST
    {
        Task<IEnumerable<MAirlineMst>> GetAirlineList();
    }
}
