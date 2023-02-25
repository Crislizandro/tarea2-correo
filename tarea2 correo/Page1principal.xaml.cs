using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tarea2_correo.model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea2_correo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1principal : ContentPage
    {
        public Page1principal()
        {
            InitializeComponent();
        }

        private void btENVIAR_Clicked(object sender, EventArgs e)
        {

            var emple = new Empleado
            {
                nombre = txtnumero1.Text,
                apellidos=txtnumero2.Text,
                edad=txtnumero3.Text,
                correo=txtnumero4.Text,

            };
            
            var secondpage = new PageResultado();
            secondpage.BindingContext= emple;
            Navigation.PushAsync (secondpage);
        }
    }
}