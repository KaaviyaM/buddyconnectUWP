using buddyConnect.Portable.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable.ViewModels
{
    public class FindFriendsViewModel : BaseViewModel
    {
        #region State Management

        public override void LoadState(object navParameter, Dictionary<string, object> state)
        {
            base.LoadState(navParameter, state);

            // load test items again; in production this would retrieve the live item by id or get it from a local data cache

        }

        public override void SaveState(Dictionary<string, object> state)
        {
            base.SaveState(state);

        }

        #endregion
    }
}
