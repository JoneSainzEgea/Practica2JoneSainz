using Practica2JoneSainz.Models;
using Practica2JoneSainz.ViewModels;

namespace Practica2JoneSainz;

/// <summary>
/// Clase que gestiona la lógica de la página de Galería.
/// Se encarga de mostrar la colección de animales y gestionar la navegación hacia los detalles.
/// </summary>
public partial class Galeria : ContentPage
{

    /// <summary>
    /// Constructor de la página Galeria.
    /// Inicializa los componentes visuales y establece el origen de los datos.
    /// </summary>
    public Galeria()
    {
        InitializeComponent();

        // Asignamos el ViewModel como contexto de datos
        BindingContext = new MainViewModel();
    }

    /// <summary>
    /// Manejador del evento que se dispara cuando el usuario selecciona un animal de la lista.
    /// </summary>
    private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedAnimal = e.CurrentSelection.FirstOrDefault() as AnimalData;

        if (selectedAnimal != null)
        {
            await Navigation.PushAsync(new AnimalDetails
            {
                BindingContext = selectedAnimal // Pasa los datos del animal seleccionado a la nueva página
            });

            ((CollectionView)sender).SelectedItem = null;
        }
    }
}
