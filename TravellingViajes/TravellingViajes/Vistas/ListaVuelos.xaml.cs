using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingViajes.Servicios;
using TravellingViajes.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaVuelos : ContentPage
	{
		public ListaVuelos ()
		{
			InitializeComponent ();
		}
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Obtén los datos de los viajes desde tu base de datos
            DatabaseService databaseService = new DatabaseService(App.DatabasePath);
            List<Viaje> listaDeViajes = databaseService.ObtenerViajes(); // Asume que tienes un método ObtenerViajes en tu servicio de base de datos

            // Establece la lista de viajes como la fuente de datos del ListView
            listaViajes.ItemsSource = listaDeViajes;
        }
    }
}