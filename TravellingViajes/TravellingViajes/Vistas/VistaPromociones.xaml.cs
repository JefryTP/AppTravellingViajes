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
    public partial class VistaPromociones : ContentPage
    {
        public VistaPromociones()
        {
            InitializeComponent();
        }
        private async void btnViajar_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert","Holaaaaa", "Ok");
        }
    }
}