using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using buddyconnectUWP.Views.HomeViews;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace buddyconnectUWP.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : ViewBase
    {
        public Home()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// An empty page that can be used on its own or navigated to within a Frame.
        /// </summary>
       

            private void chatsClick(object sender, RoutedEventArgs e)
            {
                homeFrame.Navigate(typeof(ChatsHome));
            }

            private void friendListClick(object sender, RoutedEventArgs e)
            {
                homeFrame.Navigate(typeof(BuddiesHome));
            }
        
    }
}
