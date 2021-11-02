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
using Solarizr_UWP_App.ViewModels;
using Solarizr_UWP_App.Models;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Solarizr_UWP_App.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Citas : Page
    {
        public Citas()
        {
            this.InitializeComponent();
        }

        private void listadoCitas_ItemClick(object sender, ItemClickEventArgs e)
        {
            clsCita miCita = new clsCita() ; //Coger elemento de la lista real
            Frame.Navigate(typeof(DetallesCita),miCita);
        }
    }
}
