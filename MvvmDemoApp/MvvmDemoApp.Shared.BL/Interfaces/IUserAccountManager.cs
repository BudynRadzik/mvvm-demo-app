using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmDemoApp.Shared.Models.Local;
using MvvmDemoApp.Shared.Models.Transfer;

namespace MvvmDemoApp.Shared.BL.Interfaces
{
   public interface IUserAccountManager
    {
        UserData UserData { get; set; }

        Task GetUserData();

        event EventHandler OnUserDataUpdated;
    }
}
