using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Practica2JoneSainz;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private async void OnGaleriaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Galeria());
    }

    private async void OnConfigClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Configuracion());
    }
}