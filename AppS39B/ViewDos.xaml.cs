using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS39B
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDos : ContentPage
    {
        public ViewDos(string Usuario, string Contraseña)
        {
            InitializeComponent();
            //Envio a los label
            lblUsuario.Text = Usuario;
            lblContraseña.Text = Contraseña;
            //Envio a las cajas de texto
            txtUsuario.Text = Usuario;
            txtContraseña.Text = Contraseña;
        }
    }
}