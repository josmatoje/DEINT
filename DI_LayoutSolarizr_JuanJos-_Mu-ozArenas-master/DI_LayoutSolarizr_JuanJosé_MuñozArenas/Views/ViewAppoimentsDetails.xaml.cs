using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ViewAppoimentsDetails : Page
    {
        public ViewAppoimentsDetails()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Method that set text of the appoiment selected before, so the user can see the appoiment details
        /// </summary>
        /// <param name="e"></param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            var param = (Appoiment)e.Parameter;
            txtAppoimentType.Text += param.AppoimentType;
            txtTime.Text += param.Date.TimeOfDay.ToString();
            txtDate.Text += param.Date.ToShortDateString();
            txtAddress.Text += param.Costumer.Address;
            txtName.Text += param.Costumer.Name;
            txtPhoneNumber.Text += param.Costumer.PhoneNumber;
        }
        /// <summary>
        /// Tap method, is an event associate to an appBarButton that changue current page, to previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppBarButton_TappedBack(object sender, TappedRoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewAppoiments));
        }
        /// <summary>
        /// Tap method, is an event associate to an appBarButton that show a content dialog, telling the user that the information has been sent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AppBarButton_TappedSend(object sender, TappedRoutedEventArgs e)
        {
            ContentDialog informationSending = new ContentDialog()
            {
                Title = "Send it correctly !",
                CloseButtonText = "Ok"
            };
            await informationSending.ShowAsync();
          
        }

        private async void AddImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".jpeg");
            picker.FileTypeFilter.Add(".png");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
        }
    }
}    

 

