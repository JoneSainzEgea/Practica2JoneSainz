
namespace Practica2JoneSainz.Models
{
    public class AnimalData
    {
        public string NombreComun { get; set; }
        public string NombreCientifico { get; set; }
        public string Imagen { get; set; }
        public string Clase { get; set; }
        public string Superclase { get; set; }
        public string Orden { get; set; }
        public string Familia { get; set; }
        public string Descripcion { get; set; }
    }

    public static class AnimalRepository
    {
        public static List<AnimalData> AllAnimals { get; } = new List<AnimalData>
        {
            new AnimalData
                {
                    NombreComun = "Gato",
                    NombreCientifico = "Gato",
                    Imagen = "foto_gato.jpg",
                    Clase = "Mamífero",
                    Superclase = "Mamífero",
                    Orden = "Mamífero",
                    Familia = "Mamífero",
                    Descripcion = "gato gato gato gato"
                },
                new AnimalData
                {
                    NombreComun = "Gato",
                    NombreCientifico = "Gato",
                    Imagen = "foto_gato.jpg",
                    Clase = "Mamífero",
                    Superclase = "Mamífero",
                    Orden = "Mamífero",
                    Familia = "Mamífero",
                    Descripcion = "gato gato gato gato"
                }
            };
    }
}
