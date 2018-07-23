using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private EIA_DEVContext _eIA_DEVContext;
        private ILoginRepository _login;

        public RepositoryWrapper(EIA_DEVContext eIA_DEVContext)
        {
            _eIA_DEVContext = eIA_DEVContext;
        }

        public ILoginRepository login
        {
            get
            {
                if (_login == null)
                {
                    _login = new LoginRepository(_eIA_DEVContext);
                }

                return _login;
            }
        }
    }
}
