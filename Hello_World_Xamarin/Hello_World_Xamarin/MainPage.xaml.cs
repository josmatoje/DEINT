using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Hello_World_Xamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento asociado al click del boton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async private void Button_Clicked(object sender, EventArgs e)
        {
            #region declaracion de variables
            Persona user = new Persona(txtNombre.Text);
            #endregion

            await DisplayAlert("Saludos", $"Hola, {user.Nombre}","OK");

        }
    }
}
