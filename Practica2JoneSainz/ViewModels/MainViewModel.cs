using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Practica2JoneSainz.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2JoneSainz.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<AnimalData> Animales { get; set; }

        public MainViewModel()
        {
            Animales = new ObservableCollection<AnimalData>(AnimalRepository.AllAnimals);
        }
    }
}
