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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ViewUserDetails : Page
    {
        public ViewUserDetails()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Method that is activated when you click a button of a navigationView,
        /// this method changue the current page for another depending on what was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                this.Frame.Navigate(typeof(ViewInConstruction));
            }
            else if (args.InvokedItemContainer.Content.Equals("Camera"))
            {
                this.Frame.Navigate(typeof(ViewInConstruction));
            }
            else if (args.InvokedItemContainer.Content.Equals("Home"))
            {
                this.Frame.Navigate(typeof(ViewAppoiments));
            }
        }
        /// <summary>
        /// Tap method, is an event associate to an appBarButton that log out the current user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOut_Tapped(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewLogin));
        }
        /// <summary>
        /// Tap method, is an event associate to an appBarButton that show the password or not
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPassword_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (txtPassword.Text.Contains("*")) {
                txtPassword.Text = "Password: 12345.NET6";
            }
            else{
                txtPassword.Text = "Password: **********";
            }
        }
        /// <summary>
        /// Tap method, is an event associate to an appBarButton that show to the user his gallery of photos,
        /// where he can pick one picture and set it as his user picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ChangueImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var picker=new Windows.Storage.Pickers.FileOpenPicker();
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
        }

    }
}
