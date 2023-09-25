using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pago
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class prueba : ContentPage
    {
        public prueba()
        {
            InitializeComponent();
        }
        private async void BtnConfirmarPago_Clicked(object sender, EventArgs e)
        {
            
        }

        
    }
}
