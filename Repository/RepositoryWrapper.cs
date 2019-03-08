using Contracts;
using Contracts.userManagement;
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
        private IUserCreationCRUD _userCreationCRUD;
        private IVsecLoginMst _vsecLoginMst;
        private IRoleCreation _roleCreation;
        private IVsecUserRoleMap _vsecUserRoleMap;
        private IMFlightmasterMST _mFlightmasterMST;

        public RepositoryWrapper(EIA_DEVContext eIA_DEVContext)
        {
            _eIA_DEVContext = eIA_DEVContext;
        }

        public void Dispose()
        {
            _eIA_DEVContext.Dispose();
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

        public IUserCreationCRUD userCreationCRUD
        {
            get
            {
                if (_userCreationCRUD == null)
                {
                    _userCreationCRUD = new UserCreationCRUD(_eIA_DEVContext);
                }

                return _userCreationCRUD;
            }
        }

        public IVsecLoginMst vsecLoginMst
        {
            get
            {
                if (_vsecLoginMst == null)
                {
                    _vsecLoginMst = new VsecLogMst(_eIA_DEVContext);
                }

                return _vsecLoginMst;
            }
        }

        public IRoleCreation roleCreation
        {
            get
            {
                if (_roleCreation == null)
                {
                    _roleCreation = new vseRoleMst(_eIA_DEVContext);
                }

                return _roleCreation;
            }
        }

        public IVsecUserRoleMap vsecUserRoleMap
        {
            get
            {
                if (_vsecUserRoleMap == null)
                {
                    _vsecUserRoleMap = new VsecUserRoleMapRepository(_eIA_DEVContext);
                }

                return _vsecUserRoleMap;
            }
        }

        public IMFlightmasterMST mFlightmasterMst
        {
            get
            {
                if (_mFlightmasterMST == null)
                {
                    _mFlightmasterMST = new MFlightmasterMSTRepository(_eIA_DEVContext);
                }

                return _mFlightmasterMST;
            }
        }

        public IDatabaseTransaction BeginTrainsaction()
        {
            return new EntityDatabaseTransaction(_eIA_DEVContext);
        }
    }
}
