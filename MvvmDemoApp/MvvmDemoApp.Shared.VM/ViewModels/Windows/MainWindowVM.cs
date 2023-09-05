using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemoApp.Shared.VM.ViewModels.Windows
{
    public class MainWindowVM : ObservableRecipient
    {

        #region Property: UserInfoString

        private string _userInfoString = string.Empty;
        public string UserInfoString
        {
            get
            {
                return _userInfoString;
            }
            set
            {
                _userInfoString = value;
                OnPropertyChanged(nameof(UserInfoString));
            }
        }

        #endregion

        #region RelayCommand: GetUserData
      
        public RelayCommand GetUserData
        {
            get
            {
                return new RelayCommand(async () =>
                {
                    UserInfoString = DateTime.Now.ToString();
                });
            }
        }

        #endregion

    }
}