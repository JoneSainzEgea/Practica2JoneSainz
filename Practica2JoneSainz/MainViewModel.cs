using System.Collections.ObjectModel;
using Practica2JoneSainz.Models;


namespace Practica2JoneSainz.ViewModels
{
    /// <summary>
    /// ViewModel principal de la aplicación.
    /// Actúa como intermediario entre el repositorio de datos y la vista de la Galería,
    /// preparando la información para que sea consumida mediante Binding.
    /// </summary>
    public class MainViewModel
    {
        /// <summary>
        /// Colección dinámica de animales que se sincroniza con la interfaz de usuario.
        /// </summary>
        public ObservableCollection<AnimalData> Animales { get; set; }

        /// <summary>
        /// Constructor de la clase MainViewModel.
        /// Recupera la lista de animales desde el repositorio y la carga en la colección observable.
        /// </summary>
        public MainViewModel()
        {
            Animales = new ObservableCollection<AnimalData>(AnimalRepository.AllAnimals);
        }
    }
}
