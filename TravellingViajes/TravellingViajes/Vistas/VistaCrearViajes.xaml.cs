using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

using TravellingViajes.Servicios;
using TravellingViajes.Modelos;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaCrearViajes : ContentPage
	{
		public VistaCrearViajes ()
		{
			InitializeComponent ();
            var entryPrecio = new Entry();
            entryPrecio.Keyboard = Keyboard.Numeric;
            entryPrecio.TextChanged += (s, e) =>
            {
                if (!string.IsNullOrWhiteSpace(entryPrecio.Text) && !entryPrecio.Text.Contains("."))
                {
                    entryPrecio.Text = decimal.Parse(entryPrecio.Text).ToString("N2"); // Formatea como número decimal con dos decimales
                }
            };
        }
        private void btn_crear_viaje_Clicked(object sender, EventArgs e)
        {
            // Obtén los valores de los campos
            string puntoPartida = pickerPartida.SelectedItem.ToString();
            string puntoDestino = pickerDestino.SelectedItem.ToString();
            string agencia = txtagencia.Text;

            // Validación básica: asegúrate de que los campos obligatorios no estén vacíos
            if (string.IsNullOrWhiteSpace(puntoPartida) || string.IsNullOrWhiteSpace(puntoDestino) || string.IsNullOrWhiteSpace(agencia))
            {
                DisplayAlert("Error", "Por favor, complete todos los campos obligatorios.", "OK");
                return;
            }
            // Verifica si el punto de partida y llegada son iguales
            if (puntoPartida == puntoDestino)
            {
                DisplayAlert("Error", "El punto de partida y llegada no pueden ser iguales.", "OK");
                return;
            }

            // Obtén la hora de salida y llegada seleccionadas
            TimeSpan horaSalida = txthorasalida.Time;
            TimeSpan horaLlegada = txthorallegada.Time;
            DateTime fechaSalida = txtfechasalida.Date;
            // Calcula la duración en minutos
            double duracionEnMinutos = (horaLlegada - horaSalida).TotalMinutes;
            int duracionEnMinutosEntero = (int)duracionEnMinutos;
            string horaSalidaStr = txthorasalida.Time.ToString();
            string horaLlegadaStr = txthorallegada.Time.ToString();
            // Puedes continuar aquí con la creación de un nuevo objeto "Viaje" y guardar la duración calculada
            // Por ejemplo:

            // Crea un nuevo objeto Viaje con los datos capturados
            Viaje nuevoViaje = new Viaje
            {
                PuntoPartida = puntoPartida,
                PuntoDestino = puntoDestino,
                Agencia = agencia,
                Precio = Convert.ToDouble(txtprecio.Text), // Asegúrate de manejar errores de conversión aquí
                HoraSalida = horaSalidaStr,
                HoraLlegada = horaLlegadaStr,
                Duracion = duracionEnMinutosEntero, // Almacena la duración en minutos
                FechaSalida = fechaSalida
            };

            // Luego, puedes guardar este nuevo objeto Viaje en tu base de datos o realizar cualquier otra acción necesaria

            // Por último, puedes mostrar un mensaje de éxito al usuario
            DisplayAlert("Éxito", "El viaje se ha creado correctamente.", "OK");
            DatabaseService databaseService = new DatabaseService(App.DatabasePath);
            databaseService.GuardarViaje(nuevoViaje);

            // Opcionalmente, puedes limpiar los campos después de crear el viaje
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            pickerPartida.SelectedIndex = -1;
            pickerDestino.SelectedIndex = -1;
            txtagencia.Text = string.Empty;
            txtprecio.Text = string.Empty;
            txthorasalida.Time = TimeSpan.Zero;
            txthorallegada.Time = TimeSpan.Zero;
            txtfechasalida.Date = DateTime.Now; // Establece la fecha actual como valor predeterminado
            txtduracion.Text = string.Empty;
        }

        private async void btn_ver_vuelos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaVuelos());
        }
    }
}