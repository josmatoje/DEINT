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

namespace DI_LayoutSolarizr_JuanJosé_MuñozArenas
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ViewLogin: Page
    {
        public ViewLogin()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Method click, is an event associate to button and when you click it,
        /// if one of the fields is empty, a content dialog alert to the user telling to him that each field must be fill it 
        /// with valid information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog fieldsEmpty = new ContentDialog()
            {
                Title = "Any field can be empty",
                CloseButtonText = "Ok",
                Content="Write an user and password registered"
            };
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPassword.Password))
            {
                await fieldsEmpty.ShowAsync();
            }else{
                this.Frame.Navigate(typeof(ViewAppoiments));
            }
        }


        [Obsolete("AppBarButton_TappedBack is deprecated, the new default page is the current page (the login) so you can't go back")]
        /// <summary>
        /// Method tap, is an event associate to an appBarButton that changue current page, to previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppBarButton_TappedBack(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ViewButtonLogin));
        }
        
    }
}
