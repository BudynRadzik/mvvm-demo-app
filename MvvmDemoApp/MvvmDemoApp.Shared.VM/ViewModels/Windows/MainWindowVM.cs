using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MvvmDemoApp.Shared.BL.Interfaces;
using MvvmDemoApp.Shared.Models.Local;
using MvvmDemoApp.Shared.Models.Transfer;

namespace MvvmDemoApp.Shared.VM.ViewModels.Windows
{
    public class MainWindowVM : ObservableRecipient
    {
        private IUserAccountManager _userAccountManager;

        public MainWindowVM(IUserAccountManager userAccountManager)
        {
            _userAccountManager = userAccountManager;

            _userAccountManager.OnUserDataUpdated += _userAccountManager_OnUserDataUpdated;
        }

        private void _userAccountManager_OnUserDataUpdated(object? sender, EventArgs e)
        {
            OnPropertyChanged(nameof(UserData));
        }

        #region Property: UserData

        public UserData UserData => _userAccountManager.UserData;

        #endregion

        #region RelayCommand: GetUserData

        public RelayCommand GetUserData
        {
            get
            {
                return new RelayCommand(async () =>
                {
                    await _userAccountManager.GetUserData();
                });
            }
        }

        #endregion

    }
}