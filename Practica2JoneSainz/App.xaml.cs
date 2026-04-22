namespace Practica2JoneSainz
{
    /// <summary>
    /// Clase principal de la aplicación.
    /// Responsable de inicializar los recursos globales y establecer la página de inicio.
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell(); // Establece AppShell como la página principal 
        }
    }
}
