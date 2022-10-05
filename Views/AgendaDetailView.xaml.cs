namespace NucleusDevConApp;

public partial class AgendaDetailView : ContentPage
{
    public AgendaDetailView(Session session)
    {
        InitializeComponent();
        this.BindingContext = session;
    }

    private void OnBackButtonClicked(object sender, EventArgs args) => this.Navigation.PopAsync();
}