using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using U11_ejerciciosUWP_ej3.ViewModels;
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

namespace U11_ejercicioUWP_ej3
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

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            MainPageVM viewModel = (MainPageVM) this.DataContext;
            viewModel.Eliminador.Execute(sender);
        }

        private void listado_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            ListView listado = (ListView)sender;
            MainPageVM viewModel = (MainPageVM)this.DataContext;
            //Asignamos a la persona seleccionada del viewModel la persona (por pertenecer al datacontext del listado compuesto de personas)
            //      de la fuente orioginal del elemento de XAML en el que hemos clikado de nuestro contexto de datos.
            viewModel.PersonaSeleccionada = (clsPersona)(e.OriginalSource as FrameworkElement).DataContext;
            laKey.ShowAt(listado, e.GetPosition(listado));
        }
    }
}
