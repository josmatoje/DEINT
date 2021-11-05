using Solarizr_UWP_App.Models;
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

namespace Solarizr_UWP_App.Views
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class DetallesCita : Page
    {
        #region atributos privados
        private clsCita cita;
        #endregion
        #region constructores
        public DetallesCita()
        {
            this.InitializeComponent();
        }
        public DetallesCita(clsCita cita)
        {
            this.cita = cita;
            this.InitializeComponent();
        }
        #endregion
        #region metodos publicos
        /// <summary>
        /// cabecera: protected override void OnNavigatedTo(NavigationEventArgs e)
        /// descripción: deberia de ayudarme a pasar un objeto desde el navigate view anterior
        /// precondiciones
        /// </summary>
        /// <param name="e"></param>
        /// <return> nada </return>
        /// postcondiciones:                                                                                                                                                                                                                                                                    
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                //greeting.Text = $"Hi, {e.Parameter.ToString()}";
            }
            else
            {
                //greeting.Text = "Hi!";
            }
            base.OnNavigatedTo(e);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Citas));
        }

        private void tramitar_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
