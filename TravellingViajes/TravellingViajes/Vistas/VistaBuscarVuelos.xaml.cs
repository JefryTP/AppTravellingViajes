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
    public partial class VistaBuscarVuelos : ContentPage
    {
        private List<Viaje> listaDeViajes;
        public string PuntoPartida { get; set; }
        public string PuntoDestino { get; set; }
        public DateTime FechaSeleccionada { get; set; }
        public int NumeroPasajeros { get; set; }
        public VistaBuscarVuelos(string puntoPartida, string puntoDestino, DateTime fechaSeleccionada, int numeroPasajeros)
        {
            InitializeComponent();
            PuntoPartida = puntoPartida;
            PuntoDestino = puntoDestino;
            FechaSeleccionada = fechaSeleccionada;
            NumeroPasajeros = numeroPasajeros;
            listaDeViajes = ObtenerViajesDesdeBaseDeDatos();
            BuscarViajes();
            var backButton = new Button
            {
                Text = "Volver",
                TextColor = Color.White
            };
            backButton.Clicked += (sender, e) =>
            {
                // Utiliza el método PopAsync para regresar a la página anterior
                Application.Current.MainPage = new MainPage();
            };

            // Configura la barra de navegación con el botón de regreso
            NavigationPage.SetTitleView(this, backButton);
        }
        private List<Viaje> ObtenerViajesDesdeBaseDeDatos()
        {
            // Crea una instancia de tu servicio de base de datos (DatabaseService)
            DatabaseService databaseService = new DatabaseService(App.DatabasePath);

            // Utiliza el método ObtenerViajes() de tu servicio de base de datos para obtener los viajes
            List<Viaje> viajes = databaseService.ObtenerViajes();

            return viajes;
        }
        private void BuscarViajes()
        {
            if (listaDeViajes == null)
            {
                // Maneja el caso en el que listaDeViajes aún no se ha inicializado correctamente
                return;
            }

            // Supongamos que tienes una lista de viajes llamada "listaDeViajes"
            // y quieres filtrarla según los criterios de búsqueda
            List<Viaje> viajesFiltrados = listaDeViajes
                .Where(viaje => viaje.PuntoPartida == PuntoPartida &&
                                 viaje.PuntoDestino == PuntoDestino &&
                                 viaje.FechaSalida >= FechaSeleccionada)
                .ToList();

            // Borra cualquier contenido anterior en el StackLayout
            stackLayout.Children.Clear();

            // Recorre los viajes filtrados y crea elementos visuales para cada uno
            foreach (var viaje in viajesFiltrados)
            {
                var frame = new Frame
                {
                    CornerRadius = 20,
                    Margin = new Thickness(10, 15, 10, 15),
                    HorizontalOptions = LayoutOptions.Center
                };

                var absoluteLayout = new AbsoluteLayout
                {
                    HeightRequest = 144,
                    HorizontalOptions = LayoutOptions.Center
                };

                var horaSalidaLabel = new Label
                {
                    Text = viaje.HoraSalida,
                    FontSize = 20,
                    TextColor = Color.Black,
                    Margin = new Thickness(5),
                    HorizontalTextAlignment = TextAlignment.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.End
                };

                var horaLlegadaLabel = new Label
                {
                    Text = viaje.HoraLlegada,
                    FontSize = 20,
                    TextColor = Color.Black,
                    Margin = new Thickness(330, 5, 0, 0),
                    HorizontalTextAlignment = TextAlignment.Center
                };

                var tarifaLabel = new Label
                {
                    Text = "Tarifa desde",
                    FontSize = 20,
                    TextColor = Color.Black,
                    Margin = new Thickness(250, 55, 0, 0),
                    HorizontalTextAlignment = TextAlignment.Center
                };

                var precioLabel = new Label
                {
                    Text = $"USD {viaje.Precio.ToString("F2")}", // Formatea el precio con dos decimales
                    FontSize = 20,
                    TextColor = Color.Black,
                    Margin = new Thickness(260, 95, 0, 0),
                    HorizontalTextAlignment = TextAlignment.Center
                };

                var pagarButton = new Button
                {
                    Text = "Pagar",
                    TextColor = Color.Black,
                    BackgroundColor = Color.Aqua,
                    FontSize = 17,
                    CornerRadius = 20,
                    Margin = new Thickness(2, 80, 0, 0)
                };

                absoluteLayout.Children.Add(horaSalidaLabel);
                absoluteLayout.Children.Add(horaLlegadaLabel);
                absoluteLayout.Children.Add(tarifaLabel);
                absoluteLayout.Children.Add(precioLabel);
                absoluteLayout.Children.Add(pagarButton);

                frame.Content = absoluteLayout;
                stackLayout.Children.Add(frame); // Agrega el frame al StackLayout que contiene todos los elementos

                // Asigna un manejador de eventos al botón para realizar acciones cuando se hace clic en él
                pagarButton.Clicked += (sender, e) =>
                {
                    int viajeId = viaje.Id; // Obtiene el ID del viaje

                    // Crea una instancia de FormularioPago y pasa el ID del viaje como parámetro
                    var formularioPagoPage = new FormularioPago(viajeId);

                    // Usa Navigation para navegar a la vista FormularioPago
                    Navigation.PushAsync(formularioPagoPage);
                };
            }
        }
    }
}