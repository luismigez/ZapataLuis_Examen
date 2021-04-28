using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ZapataLuis_Examen
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUser.Text;
            string clave = txtPass.Text;
            if (usuario == "estudiante2021" && clave == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("ERROR", "Usuario o Contrasenia Incorrecta", "Gracias");
            }
            
        }
    }
}
