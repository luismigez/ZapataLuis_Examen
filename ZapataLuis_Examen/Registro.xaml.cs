using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ZapataLuis_Examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;


        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string pagar = txtTotal.Text;
            await Navigation.PushAsync(new Resumen(nombre, pagar));
            DisplayAlert(" Correcto", "Elemento Guardado con Exito", "Gracias");
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
           
            try
            {
                double monto = Convert.ToDouble(txtMonto.Text);

                double saldo = (1800 - monto);
                double porc = saldo * 0.05;
                double mes = (saldo + porc)/3;
                txtMes.Text = mes.ToString();
                double total = saldo + porc + monto;
            }

            catch (Exception Ex)
            {
                //Mensaje de Error por el catch
                DisplayAlert("Alerta", Ex.Message, "Gracias");
            }
        }
    }
}