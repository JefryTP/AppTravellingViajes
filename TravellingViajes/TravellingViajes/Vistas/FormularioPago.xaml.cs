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
    public partial class FormularioPago : ContentPage
    {
        private int viajeId;
        public FormularioPago(int viajeId)
        {
            InitializeComponent();

            this.viajeId = viajeId;
        }

        private async void btnConfirmarPago_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Excelente","Compra Realizada","OK");
            Application.Current.MainPage = new MainPage();
        }
    }
}