using buddyConnect.Portable.ViewModels.HomeViewModels;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buddyConnect.Portable.ViewModels
{
     public class BaseViewModelLocator
    {
        public BaseViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<MainPageViewModel>();

            SimpleIoc.Default.Register<FindFriendsViewModel>();

            SimpleIoc.Default.Register<FriendlocationViewModel>();

            SimpleIoc.Default.Register<HomeViewModel>();

            SimpleIoc.Default.Register<NewUserViewModel>();

            SimpleIoc.Default.Register<ProfileViewModel>();

            SimpleIoc.Default.Register<RequestsViewModel>();

            SimpleIoc.Default.Register<SettingsViewModel>();

            SimpleIoc.Default.Register<HomeViewModels.BuddiesViewModel>();

            SimpleIoc.Default.Register<HomeViewModels.ChatsViewModel>();
        }

        public MainPageViewModel MainPage
        {
            get { return ServiceLocator.Current.GetInstance<MainPageViewModel>(); }
        }

        public FindFriendsViewModel FindFriends
        {
            get { return ServiceLocator.Current.GetInstance<FindFriendsViewModel>(); }
        }
        public FriendlocationViewModel FriendLocation
        {
            get { return ServiceLocator.Current.GetInstance<FriendlocationViewModel>(); }
        }
        public HomeViewModel Home
        {
            get { return ServiceLocator.Current.GetInstance<HomeViewModel>(); }
        }
        public NewUserViewModel NewUser
        {
            get { return ServiceLocator.Current.GetInstance<NewUserViewModel>(); }
        }
        public SettingsViewModel Settings
        {
            get { return ServiceLocator.Current.GetInstance<SettingsViewModel>(); }
        }
        public RequestsViewModel Requests
        {
            get { return ServiceLocator.Current.GetInstance<RequestsViewModel>(); }
        }
        public ProfileViewModel Profile
        {
            get { return ServiceLocator.Current.GetInstance<ProfileViewModel>(); }
        }
        public BuddiesViewModel Buddies
        {
            get { return ServiceLocator.Current.GetInstance<BuddiesViewModel>(); }
        }
        public ChatsViewModel Chats
        {
            get { return ServiceLocator.Current.GetInstance<ChatsViewModel>(); }
        }        
    }
}
