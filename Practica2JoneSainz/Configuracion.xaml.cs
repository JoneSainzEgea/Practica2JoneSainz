namespace Practica2JoneSainz;

public partial class Configuracion : ContentPage
{
	public Configuracion()
	{
		InitializeComponent();
	}

    private void OnThemeClicked(object sender, EventArgs e)
    {
        Application.Current.UserAppTheme =
                (Application.Current.UserAppTheme == AppTheme.Dark)
                ? AppTheme.Light
                : AppTheme.Dark;

        OnColorClicked(null, null);
    }

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

    private void OnFontFamilyClicked(object sender, EventArgs e)
    {
        var resources = Application.Current.Resources;
        string currentFont = resources["GlobalFontFamily"].ToString();

        // Lógica para cambiar de familia manteniendo el estado de negrita
        if (currentFont == "OpenSansRegular")
            resources["GlobalFontFamily"] = "CourierNew";

        else if (currentFont == "OpenSansSemibold")
            resources["GlobalFontFamily"] = "CourierNewBold";

        else if (currentFont == "CourierNew")
            resources["GlobalFontFamily"] = "OpenSansRegular";

        else if (currentFont == "CourierNewBold")
            resources["GlobalFontFamily"] = "OpenSansSemibold";
    }

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