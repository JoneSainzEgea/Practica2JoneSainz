using Practica2JoneSainz.Models;
using Practica2JoneSainz.ViewModels;

namespace Practica2JoneSainz;

public partial class Galeria : ContentPage
{
    public Galeria()
    {
        InitializeComponent();

        // Asignamos el ViewModel como contexto de datos
        BindingContext = new MainViewModel();
    }

    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedAnimal = e.CurrentSelection.FirstOrDefault() as AnimalData;

        if (selectedAnimal != null)
        {
            await Navigation.PushAsync(new AnimalDetails
            {
                BindingContext = selectedAnimal
            });

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
