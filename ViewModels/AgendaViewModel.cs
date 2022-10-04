using System.Collections.ObjectModel;
using Telerik.Maui.Controls;

namespace NucleusDevConApp;

public class AgendaViewModel : NotifyPropertyChangedBase
{
    private static DateTime FistDay = new DateTime(2022, 5, 8);
    private static DateTime SecondDay = new DateTime(2022, 5, 9);

    private int selectedDay = 0;
    private ObservableCollection<Session> sessions;

    public AgendaViewModel()
    {
        this.GetSessions();
    }

    public ObservableCollection<Session> Sessions
    {
        get => this.sessions;
        set
        {
            if (this.sessions != value)
            {
                this.sessions = value;
                this.OnPropertyChanged();
            }
        }
    }

    public int SelectedDay
    {
        get => this.selectedDay;
        set
        {
            if (this.selectedDay != value)
            {
                this.selectedDay = value;
                this.GetSessions();
                this.OnPropertyChanged();
            }
        }
    }

    private void GetSessions()
    {
        if (this.SelectedDay == 0)
        {
            this.Sessions = new ObservableCollection<Session>(Database.Sessions.FindAll(s => s.StartTime.Date == FistDay));
        }
        else
        {
            this.Sessions = new ObservableCollection<Session>(Database.Sessions.FindAll(s => s.StartTime.Date == SecondDay));
        }
    }
}