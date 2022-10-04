namespace NucleusDevConApp;

public partial class AgendaView : ContentView
{
    public AgendaView()
    {
        InitializeComponent();
    }

    private void OnSessionTapped(object sender, EventArgs args)
    {
        var session = (sender as Grid)?.BindingContext as Session;
        this.Navigation.PushAsync(new AgendaDetailView(session));
    }
}