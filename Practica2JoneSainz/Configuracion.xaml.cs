namespace Practica2JoneSainz;

/// <summary>
/// Clase que gestiona la lógica de la página de configuración.
/// Permite al usuario personalizar la apariencia visual de la aplicación.
/// </summary>
public partial class Configuracion : ContentPage
{
	public Configuracion()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Alterna el tema de la aplicación entre modo Claro y Oscuro.
    /// </summary>
    private void OnThemeClicked(object sender, EventArgs e)
    {
        AppTheme currentTheme = Application.Current.UserAppTheme;

        if (currentTheme == AppTheme.Unspecified)
        {
            currentTheme = Application.Current.RequestedTheme;
        }

        Application.Current.UserAppTheme = (currentTheme == AppTheme.Dark)
            ? AppTheme.Light
            : AppTheme.Dark;

        UpdateTextColorToTheme();
    }

    /// <summary>
    /// Actualiza el color de texto global para garantizar legibilidad al cambiar de tema.
    /// Solo actúa si el usuario no ha seleccionado un color de personalización.
    /// </summary>
    private void UpdateTextColorToTheme()
    {
        var resources = Application.Current.Resources;
        Color currentColor = (Color)resources["GlobalTextColor"];

        if (currentColor != Colors.DarkViolet)
        {
            resources["GlobalTextColor"] = (Application.Current.UserAppTheme == AppTheme.Dark)
                ? Colors.White
                : Colors.Black;
        }
    }

    /// <summary>
    /// Cambia cíclicamente el tamaño de la fuente global entre tres estados: 
    /// Pequeño (12), Normal (16) y Grande (24).
    /// </summary>
    private void OnFontSizeClicked(object sender, EventArgs e)
    {
        var resources = Application.Current.Resources;
        double current = (double)resources["GlobalFontSize"];

        if (current == 16.0)
            resources["GlobalFontSize"] = 24.0; // Grande
        else if (current == 24.0)
            resources["GlobalFontSize"] = 12.0; // Pequeño
        else
            resources["GlobalFontSize"] = 16.0; // Normal
    }

    /// <summary>
    /// Alterna la fuente global entre OpenSans y Courier New.
    /// Respeta si están en negrita.
    /// </summary>
    private void OnFontFamilyClicked(object sender, EventArgs e)
    {
        var resources = Application.Current.Resources;
        string currentFont = resources["GlobalFontFamily"].ToString();

        if (currentFont == "OpenSansRegular")
            resources["GlobalFontFamily"] = "CourierNew";

        else if (currentFont == "OpenSansSemibold")
            resources["GlobalFontFamily"] = "CourierNewBold";

        else if (currentFont == "CourierNew")
            resources["GlobalFontFamily"] = "OpenSansRegular";

        else if (currentFont == "CourierNewBold")
            resources["GlobalFontFamily"] = "OpenSansSemibold";
    }

    /// <summary>
    /// Cambia el estado de negrita de la fuente actual alternando entre 
    /// las variantes normal y negrita de la fuente seleccionada.
    /// </summary>
    private void OnBoldClicked(object sender, EventArgs e)
    {
        var resources = Application.Current.Resources;
        string currentFont = resources["GlobalFontFamily"].ToString();

        switch (currentFont)
        {
            case "OpenSansRegular":
                resources["GlobalFontFamily"] = "OpenSansSemibold";
                break;

            case "OpenSansSemibold":
                resources["GlobalFontFamily"] = "OpenSansRegular";
                break;

            case "CourierNew":
                resources["GlobalFontFamily"] = "CourierNewBold";
                break;

            case "CourierNewBold":
                resources["GlobalFontFamily"] = "CourierNew";
                break;

            default:
                resources["GlobalFontFamily"] = "OpenSansRegular";
                break;
        }
    }

    /// <summary>
    /// Alterna el color del texto global entre un color personalizado (DarkViolet)
    /// y los colores base (Blanco o Negro) dependiendo del tema activo.
    /// </summary>
    private void OnColorClicked(object sender, EventArgs e)
    {
        var resources = Application.Current.Resources;
        Color currentColor = (Color)resources["GlobalTextColor"];

        if (currentColor == Colors.DarkViolet)
        {
            resources["GlobalTextColor"] = Application.Current.UserAppTheme == AppTheme.Dark
                ? Colors.White
                : Colors.Black;
        }
        else
        {
            resources["GlobalTextColor"] = Colors.DarkViolet;
        }
    }
}