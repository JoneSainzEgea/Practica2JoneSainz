using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Practica2JoneSainz
{
    /// <summary>
    /// Clase de la página de inicio. 
    /// Gestiona la autenticación de usuarios.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        string user = "";
        string pass = "";

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador para el botón de autenticación por huella.
        /// Verifica la disponibilidad del hardware y procesa la validación biométrica.
        /// </summary>
        private async void OnFingerprintClicked(object sender, EventArgs e)
        {
            var isAvailable = await CrossFingerprint.Current.IsAvailableAsync();

            if (!isAvailable)
            {
                await DisplayAlert("Error", "La autenticación biométrica no está disponible o no está configurada.", "OK");
                return;
            }

            var request = new AuthenticationRequestConfiguration("Autenticación", "Usa tu huella para entrar");

            var result = await CrossFingerprint.Current.AuthenticateAsync(request);

            if (result.Authenticated)
            {
                var appShell = Application.Current.MainPage as AppShell;
                if (appShell != null)
                {
                    appShell.FlyoutBehavior = FlyoutBehavior.Flyout;
                    Navigation.PushAsync(new HomePage());
                }
            }
            else
            {
                await DisplayAlert("Acceso", "No se pudo reconocer la huella.", "Reintentar");
            }
        }

        /// <summary>
        /// Actualiza la variable de usuario cada vez que el texto cambia en el campo de entrada.
        /// </summary>
        void OnEntryUserTextChanged(object sender, TextChangedEventArgs e)
        {
            user = entryUser.Text;
        }

        /// <summary>
        /// Se dispara al pulsar "Enter" en el teclado sobre el campo de usuario.
        /// Valida automáticamente si el campo de contraseña ya está relleno.
        /// </summary>
        void OnEntryUserCompleted(object sender, EventArgs e)
        {
            user = ((Entry)sender).Text;
            if (pass != "")
            {
                ValidateUserAndPass();
            }
        }

        /// <summary>
        /// Actualiza la variable de contraseña cada vez que el texto cambia.
        /// </summary>
        void OnEntryPassTextChanged(object sender, TextChangedEventArgs e)
        {
            pass = entryPass.Text;
        }

        /// <summary>
        /// Se dispara al pulsar "Enter" sobre el campo de contraseña.
        /// Valida automáticamente si el campo de usuario ya está relleno.
        /// </summary>
        void OnEntryPassCompleted(object sender, EventArgs e)
        {
            pass = ((Entry)sender).Text;
            if (user != "")
            {
                ValidateUserAndPass();
            }
        }

        /// <summary>
        /// Manejador del botón de Login tradicional.
        /// </summary>
        void OnLoginClicked(object sender, EventArgs e)
        {
            ValidateUserAndPass();
        }

        /// <summary>
        /// Lógica de validación de credenciales.
        /// Si el acceso es correcto, activa el menú lateral del Shell y permite entrar a la App.
        /// </summary>
        private void ValidateUserAndPass()
        {
            if (user == "user1" & pass == "pass1")
            {
                var appShell = Application.Current.MainPage as AppShell;
                if (appShell != null)
                {
                    // Desbloqueo de la navegación lateral tras el login exitoso
                    appShell.FlyoutBehavior = FlyoutBehavior.Flyout;
                    Navigation.PushAsync(new HomePage());
                }
            }
            else
                DisplayAlert("Acceso denegado", "Usuario o contraseña incorrectos", "Volver a intentar");
        }
    }
}
