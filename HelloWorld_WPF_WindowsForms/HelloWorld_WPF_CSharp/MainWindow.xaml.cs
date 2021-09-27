using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MisClases;

namespace HelloWorld_WPF_CSharp
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, RoutedEventArgs e)
        {
            //Insatanciacion y declaracion
            //clsPersona persona = new clsPersona();

            if (String.IsNullOrEmpty(txt_nombre.Text))

                MessageBox.Show("Introduzca un valor");
            else
                MessageBox.Show($"Saludos joven {txt_nombre.Text}");


        }

        
    }
}
