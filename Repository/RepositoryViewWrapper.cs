using Contracts;
using Contracts.Masters;
using Contracts.UserManagement;
using Entities.ViewModels;
using Repository.Masters;
using Repository.UserManagementRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryViewWrapper : IRepositoryViewWrapper
    {
        private EIA_DEVContext_View _eIA_DEVContext_view;
        private IUserCreation _userCreation;
        private IcourierMst _courierMst;

        public RepositoryViewWrapper(EIA_DEVContext_View eIA_DEVContext_view)
        {
            _eIA_DEVContext_view = eIA_DEVContext_view;
        }

        public IUserCreation userCreation
        {
            get
            {
                if (_userCreation == null)
                {
                    _userCreation = new UserCreation(_eIA_DEVContext_view);
                }

                return _userCreation;
            }
        }

        public IcourierMst courierMst
        {
            get
            {
                if (_courierMst == null)
                {
                    _courierMst = new CourierDetails(_eIA_DEVContext_view);
                }

                return _courierMst;
            }
        }
    }
}
