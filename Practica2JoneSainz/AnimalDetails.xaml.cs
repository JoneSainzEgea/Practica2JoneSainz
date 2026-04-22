namespace Practica2JoneSainz;

/// <summary>
/// Clase que gestiona la lógica de la página de detalles de un animal.
/// Muestra información extendida y permite la navegación de retorno.
/// </summary>
public partial class AnimalDetails : ContentPage
{
	public AnimalDetails()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Manejador del evento de clic para el botón de cierre o retorno.
    /// Utiliza la pila de navegación para volver a la pantalla anterior.
    /// </summary>
    private async void OnCloseClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}