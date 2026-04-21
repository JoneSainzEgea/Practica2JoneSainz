namespace Practica2JoneSainz;

public partial class AnimalDetails : ContentPage
{
	public AnimalDetails()
	{
		InitializeComponent();
	}

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}