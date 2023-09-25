using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using TravellingViajes.Modelos;
using TravellingViajes.Servicios;

namespace TravellingViajes.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormularioRegistrar : ContentPage
    {
        public FormularioRegistrar()
        {
            InitializeComponent();
        }

        private async void btn_registrarse_Clicked(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtnombre.Text) ||
                string.IsNullOrWhiteSpace(txtapellidopa.Text) ||
                string.IsNullOrWhiteSpace(txtapellidoma.Text) ||
                string.IsNullOrWhiteSpace(txtedad.Text) ||
                string.IsNullOrWhiteSpace(txtcorreo.Text) ||
                string.IsNullOrWhiteSpace(txtcontrasena.Text))
            {
                await DisplayAlert("Campos incompletos", "Por favor, completa todos los campos.", "OK");
                return; // Salir del método si los campos están incompletos
            }

            // Obtener los datos ingresados por el usuario
            string nombre = txtnombre.Text;
            string apellidoPa = txtapellidopa.Text;
            string apellidoMa = txtapellidoma.Text;

            if (!int.TryParse(txtedad.Text, out int edad))
            {
                await DisplayAlert("Edad inválida", "La edad debe ser un número entero.", "OK");
                return; // Salir del método si la edad no es válida
            }

            string correo = txtcorreo.Text;
            string contrasena = txtcontrasena.Text;

            // Crear un nuevo objeto Usuario con los datos ingresados
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = nombre,
                ApellidoPaterno = apellidoPa,
                ApellidoMaterno = apellidoMa,
                Edad = edad,
                Correo = correo,
                Contraseña = contrasena
            };

            // Guardar el nuevo usuario en la base de datos
            DatabaseService databaseService = new DatabaseService(App.DatabasePath); // App.DatabasePath debe ser accesible desde esta página
            databaseService.GuardarUsuario(nuevoUsuario);

            // Mostrar un mensaje de éxito
            await DisplayAlert("Registro exitoso", "El usuario se ha registrado correctamente.", "OK");
            txtnombre.Text = string.Empty;
            txtapellidopa.Text = string.Empty;
            txtapellidoma.Text = string.Empty;
            txtedad.Text = "";
            txtcorreo.Text = string.Empty;
            txtcontrasena.Text = string.Empty;

            // Regresar a la página anterior (la TabbedPage)
            await Navigation.PopAsync();
        }
    }
}