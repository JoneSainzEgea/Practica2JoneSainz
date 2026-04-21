using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Practica2JoneSainz
{
    public partial class MainPage : ContentPage
    {
        string user = "";
        string pass = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnFingerprintClicked(object sender, EventArgs e)
        {
            var request = new AuthenticationRequestConfiguration("Autenticación", "Autenticar con huella");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);
            if (result.Authenticated)
                await DisplayAlert("Acceso", "Acceso concedido", "Cerrar");
            else
                await DisplayAlert("Acceso", "Acceso denegado", "Cerrar");
        }

        void OnEntryUserTextChanged(object sender, TextChangedEventArgs e)
        {
            //string oldText = e.OldTextValue;
            //string newText = e.NewTextValue;
            user = entryUser.Text;
        }

        void OnEntryUserCompleted(object sender, EventArgs e)
        {
            user = ((Entry)sender).Text;
            if (pass != "")
            {
                ValidateUserAndPass();
            }
        }
        void OnEntryPassTextChanged(object sender, TextChangedEventArgs e)
        {
            //string oldText = e.OldTextValue;
            //string newText = e.NewTextValue;
            pass = entryPass.Text;
        }

        void OnEntryPassCompleted(object sender, EventArgs e)
        {
            pass = ((Entry)sender).Text;
            if (user != "")
            {
                ValidateUserAndPass();
            }
        }

        void OnLoginClicked(object sender, EventArgs e)
        {
            ValidateUserAndPass();
        }

        private void ValidateUserAndPass()
        {
            if (user == "user1" & pass == "pass1")
            {
                var appShell = Application.Current.MainPage as AppShell;
                if (appShell != null)
                {
                    appShell.FlyoutBehavior = FlyoutBehavior.Flyout;
                    Navigation.PushAsync(new HomePage());
                }
            }
            else
                DisplayAlert("Login error", "Incorrect user or password", "Try again");
        }
    }

}
