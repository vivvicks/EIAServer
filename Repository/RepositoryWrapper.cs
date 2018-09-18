using Contracts;
using Contracts.UserManagement;
using Entities.Models;
using Entities.ViewModels;
using Repository.UserManagementRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private EIA_DEVContext _eIA_DEVContext;
        private ILoginRepository _login;
        private ICommonMaster _commonMaster;
        private IMAirlineMST _AirlineMST;

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

        public ICommonMaster commonMaster
        {
            get
            {
                if (_commonMaster == null)
                {
                    _commonMaster = new CommonMasterRepository(_eIA_DEVContext);
                }

                return _commonMaster;
            }
        }

        public IMAirlineMST mAirlineMST
        {
            get
            {
                if (_AirlineMST == null)
                {
                    _AirlineMST = new MAirlineMSTRepository(_eIA_DEVContext);
                }

                return _AirlineMST;
            }
        }
    }
}
