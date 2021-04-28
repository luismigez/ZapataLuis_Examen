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
    public partial class Resumen : ContentPage
    {
        public Resumen(String nombre, String pagar)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            txtTotal.Text = pagar
        }
    }
}