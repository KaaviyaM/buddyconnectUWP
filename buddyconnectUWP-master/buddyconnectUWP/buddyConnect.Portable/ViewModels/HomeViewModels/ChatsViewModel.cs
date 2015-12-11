using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using buddyConnect.Portable.Models.HomeModels;
using System.Collections.ObjectModel;

namespace buddyConnect.Portable.ViewModels.HomeViewModels
{
    public class ChatsViewModel : BaseViewModel
    {
        private ObservableCollection<chatsHomeDatum> chatsOC = new ObservableCollection<chatsHomeDatum>();
        public ObservableCollection<chatsHomeDatum> ChatsOC
        {
            get { return chatsOC; }
            set
            {
                chatsOC = value;
                RaisePropertyChanged();
            }
        }



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
