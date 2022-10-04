using Telerik.Maui.Controls;

namespace NucleusDevConApp;

public class AgendaViewModel : NotifyPropertyChangedBase
{
    private int selectedDay = 0;

    public int SelectedDay
    {
        get
        {
            return this.selectedDay;
        }
        set
        {
            if (this.selectedDay != value)
            {
                this.selectedDay = value;
                this.OnPropertyChanged();
            }
        }
    }
}