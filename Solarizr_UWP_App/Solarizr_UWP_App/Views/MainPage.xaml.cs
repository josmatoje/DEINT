using Solarizr_UWP_App.Views;
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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace Solarizr_UWP_App
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// cabecera: private void Enter_Click(object sender, RoutedEventArgs e)
        /// descripción: comprueba que existe un usuario y una contraseña y en caso afirmativo avanza a la vista de citas, en caso contrario muestra un mensaje de error
        /// precondiciones: ninguna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <return> nada </return>
        /// postcondiciones: ninguna
        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (userData.Text.Equals("") || passwordData.Password.Equals(""))
            {
                Alerta.Visibility = Visibility.Visible;
            }
            else
            {
                Frame.Navigate(typeof(Citas));
            }
            
        }

    }
}
