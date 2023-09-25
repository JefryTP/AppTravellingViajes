using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaViajes : ContentPage
    {
        public VistaViajes()
        {
            InitializeComponent();
        }
        private async void btn_buscar_vuelos_Clicked(object sender, EventArgs e)
        {
            string puntoPartida = pickerPartida.SelectedItem?.ToString();
            string puntoDestino = pickerDestino.SelectedItem?.ToString();
            DateTime fechaSeleccionada = pickerFechasalida.Date;
            int numeroPasajeros;

            // Verifica si el valor en txtpasajeros es válido y lo convierte a entero
            if (int.TryParse(txtpasajeros.Text, out numeroPasajeros))
            {
                // Crea una nueva instancia de la vista VistaBuscarVuelos y pasa los datos como argumentos
                VistaBuscarVuelos vistaBuscarVuelos = new VistaBuscarVuelos(puntoPartida, puntoDestino, fechaSeleccionada, numeroPasajeros);

                // Utiliza Navigation para navegar a la nueva vista
                Application.Current.MainPage = new NavigationPage(vistaBuscarVuelos);
            }
            else
            {
                // Muestra un mensaje de error si el valor no es válido
                await DisplayAlert("Error", "Ingrese un número válido de pasajeros", "OK");
            }
        }
    }
}