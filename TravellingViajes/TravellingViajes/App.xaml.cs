using System;
using Xamarin.Forms;
using TravellingViajes.Vistas;
using Xamarin.Forms.Xaml;

namespace TravellingViajes
{
    public partial class App : Application
    {
        public static string DatabasePath { get; set; }
        public App()
        {
            InitializeComponent();
            DatabasePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Viaje.db3");
            MainPage = new NavigationPage(new VistaLogin());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
