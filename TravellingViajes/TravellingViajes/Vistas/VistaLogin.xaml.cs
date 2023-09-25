using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TravellingViajes.Modelos;
using TravellingViajes.Servicios;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VistaLogin : ContentPage
	{
		public VistaLogin ()
		{
			InitializeComponent ();
            SessionManager.ClearUserId();
        }
        public async void btn_registrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FormularioRegistrar());
        }
        private async void btn_loguear_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtcorreo.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtcontrasena.Text))
                {
                    string correo = txtcorreo.Text;
                    string contraseña = txtcontrasena.Text;
                    if (correo=="admin1" || contraseña=="123456")
                    {
                        await DisplayAlert("Éxito", "Inicio de sesión como Administrador", "OK");
                        txtcorreo.Text = string.Empty;
                        txtcontrasena.Text = string.Empty;
                        await Navigation.PushAsync(new VistaCrearViajes());
                    }
                    else
                    {
                     
                    if (Regex.IsMatch(correo, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$"))
                    {
                        if (contraseña.Length > 6)
                        {
                            DatabaseService databaseService = new DatabaseService(App.DatabasePath);
                            Usuario usuario = databaseService.ObtenerUsuarioPorCorreo(correo);

                            if (usuario != null && usuario.Contraseña == contraseña)
                            {
                                await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");
                                txtcorreo.Text = string.Empty;
                                txtcontrasena.Text = string.Empty;
                                    SessionManager.SetUserId(usuario.Id);
                                    Application.Current.MainPage = new MainPage();
                            }
                            else
                            {
                                await DisplayAlert("Error", "Credenciales inválidas", "OK");
                                return;
                            }
                        }
                        else
                        {
                            await DisplayAlert("Error", "La contraseña debe tener al menos 6 caracteres.", "OK");
                            return;
                        }
                    }
                    else
                    {
                        await DisplayAlert("Error", "Ingrese una dirección de correo electrónico válida.", "OK");
                        return;
                    }

                    }
                }
                else
                {
                    await DisplayAlert("Error", "Por favor, ingrese contraseña.", "OK");
                    return;
                }
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese correo.", "OK");
                return;
            }
        }
    }
}