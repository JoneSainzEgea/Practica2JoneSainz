namespace Practica2JoneSainz;

public partial class Configuracion : ContentPage
{
	public Configuracion()
	{
		InitializeComponent();
	}

    private void OnThemeClicked(object sender, EventArgs e)
    {
        if (Application.Current.UserAppTheme == AppTheme.Dark)
        {
            Application.Current.UserAppTheme = AppTheme.Light;
        }
        else
        {
            Application.Current.UserAppTheme = AppTheme.Dark;
        }
    }

    private void OnFontSizeClicked(object sender, EventArgs e)
    {
        double currentSize = (double)Application.Current.Resources["globalFontSize"];

        if (currentSize == 16) // De Normal a Grande
            Application.Current.Resources["globalFontSize"] = 24.0;
        else if (currentSize == 24) // De Grande a Pequeño
            Application.Current.Resources["globalFontSize"] = 12.0;
        else // De Pequeño a Normal
            Application.Current.Resources["globalFontSize"] = 16.0;
    }

    private void OnFontFamilyClicked(object sender, EventArgs e)
    {
        if (Application.Current.Resources["globalFontFamily"].ToString() == "OpenSansRegular")
        {
            Application.Current.Resources["globalFontFamily"] = "Courier New";
        }
        else
        {
            Application.Current.Resources["globalFontFamily"] = "OpenSansRegular";
        }
    }

    private void OnColorClicked(object sender, EventArgs e)
    {
        Color currentColor = (Color)Application.Current.Resources["globalTextColor"];

        if (currentColor == Colors.Black || currentColor == Colors.White)
        {
            Application.Current.Resources["globalTextColor"] = Colors.DarkGreen;
        }
        else
        {
            // Devolvemos el color según el tema actual
            Application.Current.Resources["globalTextColor"] =
                Application.Current.UserAppTheme == AppTheme.Dark ? Colors.White : Colors.Black;
        }
    }
}