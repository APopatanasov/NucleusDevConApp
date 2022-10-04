namespace NucleusDevConApp;

public static class Database
{
    public static List<Session> Sessions { get; set; }
    public static List<Speaker> Speakers { get; set; }
    public static List<Sponsor> Sponsors { get; set; }

    static Database()
    {
        Speakers = new List<Speaker>
        {
            new Speaker
            {
                Id = "1",
                Name = "John Smith",
                Bio = "John is a Microsoft MVP and a .NET MAUI Certified Mobile Developer. He is a software developer at Telerik and has been working with Xamarin and .NET MAUI since 2014.",
                Image = "person_1.png"
            },
            new Speaker
            {
                Id = "2",
                Name = "David Ortinau",
                Bio = "David is a Principal Product Manager for .NET at Microsoft, focused on .NET MAUI. A .NET developer since 2002, and versed in a range of programming languages, David has developed web, environmental, and mobile experiences for a wide variety of industries.",
                Image = "person_2.png"
            },
        };

        Sessions = new List<Session>
        {
            new Session
            {
                Id = "1",
                Name = "Introduction to .NET MAUI",
                Description = "Learn the basics of .NET MAUI and how to build cross-platform mobile apps with it.",
                Speaker = Speakers[0],
                StartTime = new DateTime(2022, 5, 8, 9, 0, 0),
                EndTime = new DateTime(2022, 10, 8, 10, 0, 0),
            },
            new Session
            {
                Id = "1",
                Name = "Let’s Make Crazy Beautiful UI With Maui",
                Description = ".NET MAUI may have been originally considered best for building rapid prototypes, but customers have shown us time and again that the only limits to its power is your imagination. In this session we'll take 4 beautiful designs and demonstrate the techniques used to create them. We'll cover layout, styling, bindings, animations, behaviors, drawing, and more.",
                Speaker = Speakers[1],
                StartTime = new DateTime(2022, 5, 9, 9, 0, 0),
                EndTime = new DateTime(2022, 10, 9, 10, 0, 0),
            },
        };
    }
}