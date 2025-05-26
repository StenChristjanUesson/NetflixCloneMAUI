using static System.Net.Mime.MediaTypeNames;

namespace NetflixCloneMAUI;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}