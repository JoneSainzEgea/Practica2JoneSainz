namespace Practica2JoneSainz;

/// <summary>
/// Clase que gestiona la lógica de la página principal.
/// Actúa como un menú centralizado para dirigir al usuario a las diferentes secciones de la app.
/// </summary>
public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Manejador del evento de clic para el acceso a la Galería.
    /// </summary>
    private async void OnGaleriaClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Galeria());
    }

    /// <summary>
    /// Manejador del evento de clic para el acceso a la Configuración.
    /// </summary>
    private async void OnConfigClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Configuracion());
    }
}