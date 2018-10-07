using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IDatabaseTransaction : IDisposable
    {
        void Commit();
        void Rollback();
    }
}
