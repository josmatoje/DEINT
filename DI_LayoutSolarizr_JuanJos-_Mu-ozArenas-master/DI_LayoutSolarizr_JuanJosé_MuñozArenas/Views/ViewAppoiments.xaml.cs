using DI_LayoutSolarizr_JuanJosé_MuñozArenas;
using DI_LayoutSolarizr_JuanJosé_MuñozArenas.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Contacts;
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
    public sealed partial class ViewAppoiments : Page
    {
        
        public ViewAppoiments()
        {
            this.InitializeComponent();
            
        }
        /// <summary>
        /// Method click, is an event associate to a gridView that contains every appoiments and when you click in one of them,
        /// the actual page changue to another page that show the details of the appoiment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grid_ItemClick(object sender, ItemClickEventArgs e)
        {
            Appoiment selected = e.ClickedItem as Appoiment; 
            this.Frame.Navigate(typeof(ViewAppoimentsDetails),selected);
        }

        /// <summary>
        /// Method that is activated when you click a button of a navigationView,
        /// this method changue the current page for another depending on what was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nvAppoiments_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.IsSettingsInvoked)
            {
                this.Frame.Navigate(typeof(ViewInConstruction));
            }
            else if(args.InvokedItemContainer.Content.Equals("Camera"))
            {
                this.Frame.Navigate(typeof(ViewInConstruction));
            }
            else if (args.InvokedItemContainer.Content.Equals("Users")) 
            {
                this.Frame.Navigate(typeof(ViewUserDetails));
            }
        }
    }
}