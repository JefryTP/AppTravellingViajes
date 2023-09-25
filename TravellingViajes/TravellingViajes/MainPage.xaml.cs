using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingViajes.Servicios;
using TravellingViajes.Vistas;
using Xamarin.Forms;

namespace TravellingViajes
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            if (SessionManager.UserId == 0)
            {
                // Muestra un mensaje de error
                DisplayAlert("Error", "Debes iniciar sesión para acceder a esta página.", "OK");

                // Redirige al usuario a la página de inicio de sesión
                Application.Current.MainPage = new NavigationPage(new VistaLogin());
            }
        }
    }
}
