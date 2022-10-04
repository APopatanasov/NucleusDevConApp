namespace NucleusDevConApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
#if ANDROID
        Application.AccentColor = Color.FromArgb("#2B0B98");
#endif
        MainPage = new NavigationPage(new MainPage());
    }
}