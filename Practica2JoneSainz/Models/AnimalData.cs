
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
                NombreCientifico = "Felis catus",
                Imagen = "foto_gato.jpg",
                Clase = "Mammalia",
                Superclase = "Tetrapoda",
                Orden = "Carnivora",
                Familia = "Felidae",
                Descripcion = "El gato doméstico es conocido por ser un ágil depredador nocturno y una mascota popular. Se caracteriza por su cuerpo flexible, garras retráctiles, sentidos agudos y comportamiento independiente, higiénico y territorial, con un promedio de vida de 12 a 18 años."
            },
            new AnimalData
            {
                NombreComun = "Perro",
                NombreCientifico = "Canis familiaris",
                Imagen = "foto_perro.jpg",
                Clase = "Mammalia",
                Superclase = "Tetrapoda",
                Orden = "Carnivora",
                Familia = "Canidae",
                Descripcion = "El perro se distingue por su lealtad y estrecha relación con los humanos. Posee un sentido del olfato y oído altamente desarrollados, una gran diversidad de razas y una estructura social basada en la jerarquía, siendo capaz de realizar tareas de guarda, caza o compañía."
            },
            new AnimalData
            {
                NombreComun = "Cerdo",
                NombreCientifico = "Sus scrofa domestica",
                Imagen = "foto_cerdo.jpg",
                Clase = "Mammalia",
                Superclase = "Tetrapoda",
                Orden = "Artiodactyla",
                Familia = "Suidae",
                Descripcion = "El cerdo se caracteriza por su cuerpo robusto, hocico móvil y sensible, y una piel cubierta de cerdas. Son animales sociales, curiosos y con una gran capacidad de aprendizaje, que se adaptan a diversos entornos climáticos."
            },
            new AnimalData
            {
                NombreComun = "Cigüeña",
                NombreCientifico = "Ciconia ciconia",
                Imagen = "foto_ciguena.jpg",
                Clase = "Aves",
                Superclase = "Tetrapoda",
                Orden = "Ciconiiformes",
                Familia = "Ciconiidae",
                Descripcion = "Ave migratoria de gran tamaño conocida por su plumaje blanco y negro y su pico largo y rojo. Construye nidos voluminosos en lugares elevados y es famosa por su fidelidad al nido y por recorrer miles de kilómetros en sus migraciones anuales entre Europa y África."
            },
            new AnimalData
            {
                NombreComun = "Elefante",
                NombreCientifico = "Loxodonta africana",
                Imagen = "foto_elefante.jpg",
                Clase = "Mammalia",
                Superclase = "Tetrapoda",
                Orden = "Proboscidea",
                Familia = "Elephantidae",
                Descripcion = "Es el animal terrestre más grande que existe. Destaca por su larga trompa prensil, grandes colmillos de marfil y orejas amplias. Poseen una inteligencia excepcional, una memoria prodigiosa y estructuras sociales complejas lideradas por una matriarca."
            },
            new AnimalData
            {
                NombreComun = "Saltamontes",
                NombreCientifico = "Caelifera",
                Imagen = "foto_saltamontes.jpg",
                Clase = "Insecta",
                Superclase = "Hexapoda",
                Orden = "Orthoptera",
                Familia = "Acrididae",
                Descripcion = "Insecto herbívoro adaptado para el salto gracias a sus potentes patas traseras. Posee dos pares de alas y órganos auditivos situados en el abdomen. Es conocido por su capacidad de producir sonidos rítmicos frotando sus patas contra las alas y por su mimetismo con la vegetación."
            },
            new AnimalData
            {
                NombreComun = "Mosca",
                NombreCientifico = "Musca domestica",
                Imagen = "foto_mosca.jpg",
                Clase = "Insecta",
                Superclase = "Hexapoda",
                Orden = "Diptera",
                Familia = "Muscidae",
                Descripcion = "Pequeño insecto volador caracterizado por tener un solo par de alas funcionales y un aparato bucal succionador. Posee ojos compuestos con miles de facetas que le dan una visión casi total de su entorno, siendo un agente clave en la descomposición de materia orgánica."
            },
            new AnimalData
            {
                NombreComun = "Abeja",
                NombreCientifico = "Apis mellifera",
                Imagen = "foto_abeja.jpg",
                Clase = "Insecta",
                Superclase = "Hexapoda",
                Orden = "Hymenoptera",
                Familia = "Apidae",
                Descripcion = "Insecto polinizador esencial para los ecosistemas. Vive en colonias organizadas con una reina, zánganos y obreras. Se distingue por su cuerpo cubierto de vellosidades que recogen polen, su capacidad para producir miel y cera, y su complejo sistema de comunicación mediante danzas."
            }
            };
    }
}
