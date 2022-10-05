namespace NucleusDevConApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Application.AccentColor = Color.FromArgb("#00299E");
        MainPage = new NavigationPage(new MainPage());
    }
}