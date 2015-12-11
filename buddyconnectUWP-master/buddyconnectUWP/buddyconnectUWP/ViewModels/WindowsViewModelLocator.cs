using buddyConnect.Portable.ViewModels;
using buddyConnect.Portable.ViewModels.HomeViewModels;
using buddyconnectUWP.Views;
using buddyconnectUWP.Views.HomeViews;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buddyconnectUWP.ViewModels
{
    public class WindowsViewModelLocator : BaseViewModelLocator
    {
        public WindowsViewModelLocator() : base()
        {
            
                var navigationService = InitNavigationService();
                SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            
        }

        protected INavigationService InitNavigationService()
        {
            var service = new NavigationService();

            service.Configure(typeof(MainPageViewModel).FullName, typeof(MainPage));
            service.Configure(typeof(FindFriendsViewModel).FullName, typeof(FindFriends));

            service.Configure(typeof(FriendlocationViewModel).FullName, typeof(FriendsLocation));
            service.Configure(typeof(HomeViewModel).FullName, typeof(Home));

            service.Configure(typeof(NewUserViewModel).FullName, typeof(NewUser));
            service.Configure(typeof(ProfileViewModel).FullName, typeof(Profile));

            service.Configure(typeof(RequestsViewModel).FullName, typeof(Requests));
            service.Configure(typeof(SettingsViewModel).FullName, typeof(Settings));

            service.Configure(typeof(BuddiesViewModel).FullName, typeof(BuddiesHome));
            service.Configure(typeof(ChatsViewModel).FullName, typeof(ChatsHome));

            return service;
        }
    }
}
