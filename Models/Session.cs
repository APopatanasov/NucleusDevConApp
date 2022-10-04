namespace NucleusDevConApp;

public class Session
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Speaker Speaker { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string Map { get; set; }
    public string Image { get; set; }
}