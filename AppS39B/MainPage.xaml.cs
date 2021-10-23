using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS39B
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //Alamacenar los datos en varibles
            string usuario = txtusuario.Text;
            string contraseña = txtcontraseña.Text;

            //Navegando la ventana dos
            await Navigation.PushAsync(new ViewDos(usuario,contraseña));
        }
    }
}
