using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tarea2_correo.view
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageListEmple : ContentPage
	{
		public PageListEmple ()
		{
			InitializeComponent ();
		}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
			List<model.Empleado> empleados=new List<model.Empleado> ();
			empleados = await App.Database.GetListEmple();
            listemple.ItemsSource=empleados;
        }

        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}