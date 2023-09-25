using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TravellingViajes.Servicios;
using Xamarin.Forms.Xaml;
using TravellingViajes.Modelos;

namespace TravellingViajes.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaPerfil : ContentPage
    {
        private bool isEditing = false;
        public VistaPerfil()
        {
            InitializeComponent();
            SetEditingMode(isEditing);
        }
        private void SetEditingMode(bool editing)
        {
            // Configura la visibilidad y capacidad de edición de los elementos
            txtcorreo.IsReadOnly = !editing;
            txtcontrasena.IsReadOnly = !editing;
            txtedad.IsReadOnly = !editing;
            txtnombre.IsReadOnly = !editing;
            txtapellidoma.IsReadOnly = !editing;
            txtapellidopa.IsReadOnly = !editing;
            frameCerrar.IsVisible = !editing;

            btn_modificar.IsVisible = !editing;
            btn_actualizar.IsVisible = editing;
            btn_regresar.IsVisible = editing;

            isEditing = editing;
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Obtén el usuario actual desde la base de datos según su ID
            int userId = SessionManager.UserId;
            if (userId != 0)
            {
                DatabaseService databaseService = new DatabaseService(App.DatabasePath);
                Usuario usuario = databaseService.ObtenerUsuarioPorId(userId);

                if (usuario != null)
                {
                    // Llena los campos con los datos del usuario
                    txtnombre.Text = usuario.Nombre;
                    txtapellidopa.Text = usuario.ApellidoPaterno;
                    txtapellidoma.Text = usuario.ApellidoMaterno;
                    txtcorreo.Text = usuario.Correo;
                    txtedad.Text = usuario.Edad.ToString();
                    txtcontrasena.Text = usuario.Contraseña;
                }
            }
        }
        private void btn_cerrar_Clicked(object sender, EventArgs e)
        {
            SessionManager.ClearUserId();
            Application.Current.MainPage = new NavigationPage(new VistaLogin());
        }

        private void btn_modificar_Clicked(object sender, EventArgs e)
        {
            SetEditingMode(true);
        }

        private async void btn_actualizar_Clicked(object sender, EventArgs e)
        {
            // Obtén los nuevos valores de los campos de texto
            string nuevoNombre = txtnombre.Text;
            string nuevoApellidoPa = txtapellidopa.Text;
            string nuevoApellidoMa = txtapellidoma.Text;
            string nuevoCorreo = txtcorreo.Text;
            string nuevaContrasena = txtcontrasena.Text;
            int nuevaEdad;

            // Asegúrate de manejar errores al convertir la edad, por ejemplo, si el usuario ingresa un valor no válido.
            if (!int.TryParse(txtedad.Text, out nuevaEdad))
            {
                // Manejo de error aquí (puedes mostrar un mensaje al usuario)
                await DisplayAlert("Alerta", "Ingresa una edad valida", "OK");
                return;
            }

            // Obtén el usuario actual desde la base de datos según su ID
            int userId = SessionManager.UserId;
            if (userId != 0)
            {
                DatabaseService databaseService = new DatabaseService(App.DatabasePath);
                Usuario usuario = databaseService.ObtenerUsuarioPorId(userId);

                if (usuario != null)
                {
                    // Actualiza los datos del usuario con los nuevos valores
                    usuario.Nombre = nuevoNombre;
                    usuario.ApellidoPaterno = nuevoApellidoPa;
                    usuario.ApellidoMaterno = nuevoApellidoMa;
                    usuario.Correo = nuevoCorreo;
                    usuario.Contraseña = nuevaContrasena;
                    usuario.Edad = nuevaEdad;
                     

                    // Llama a la función de tu servicio de base de datos para actualizar el usuario
                    databaseService.ActualizarUsuario(usuario);

                    // Restaura la visibilidad y capacidad de edición a su estado inicial
                    SetEditingMode(false);

                    // Actualiza el contenido de los campos de texto con los nuevos valores
                    txtnombre.Text = nuevoNombre;
                    txtapellidopa.Text = nuevoApellidoPa;
                    txtapellidoma.Text = nuevoApellidoMa;
                    txtedad.Text = nuevaEdad.ToString();
                    txtcorreo.Text = nuevoCorreo;
                    txtcontrasena.Text = nuevaContrasena;
                }
            }
        }

        private void btn_regresar_Clicked(object sender, EventArgs e)
        {
            // Restaura la visibilidad y capacidad de edición a su estado inicial
            SetEditingMode(false);

            // Restaura el contenido de los campos de texto con los valores originales
            // Esto se hará en caso de que se hayan realizado cambios no guardados
        }
    }
}