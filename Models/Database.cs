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
                Name = "John Pitt",
                Bio = "John is a Microsoft MVP and a .NET MAUI Certified Mobile Developer. He is a software developer at Telerik and has been working with Xamarin and .NET MAUI since 2014.",
                Image = "person_2.png"
            },
            new Speaker
            {
                Id = "2",
                Name = "David Williams",
                Bio = "David is a Principal Product Manager for .NET at Microsoft, focused on .NET MAUI. A .NET developer since 2002, and versed in a range of programming languages, David has developed web, environmental, and mobile experiences for a wide variety of industries.",
                Image = "person_6.png"
            },
            new Speaker
            {
                Id = "3",
                Name = "Megan Smith",
                Bio = "Megan is a Senior Product Manager at Telerik. She has been working with Sitefinity since 2010 and has been a Sitefinity MVP since 2013.",
                Image = "person_8.png"
            },
        };

        Sessions = new List<Session>
        {
            new Session
            {
                Id = "1",
                Name = "Why You Should Build Your Next Sitefinity Project on .NET Core",
                Description = "Attend this session to hear a case study with tips for migrating to .NET Core, to learn how our decoupled architecture enables you to build and deliver next-gen digital experiences.",
                Speaker = Speakers[0],
                StartTime = new DateTime(2022, 9, 11, 10, 0, 0),
                EndTime = new DateTime(2022, 9, 11, 11, 0, 0),
                Image = "session1.png",
                Map = "map1.jpeg"
            },
            new Session
            {
                Id = "1",
                Name = "Pro Tips for Building Personas and Journey Mapsh",
                Description = "In this session, you'll learn the specifics of how to create personas and journey maps and also what tools and resources will help you get this done quickly.",
                Speaker = Speakers[1],
                StartTime = new DateTime(2022, 9, 11, 9, 0, 0),
                EndTime = new DateTime(2022, 9, 11, 10, 0, 0),
                Image = "session2.png",
                Map = "map1.jpeg"
            },
            new Session
            {
                Id = "2",
                Name = "Workshop: Optimize Your Online Patient Experiences",
                Description = "Learn the key requirements and milestones to help health care providers create and orchestrate compliant, patient-centric digital journeys.",
                Speaker = Speakers[2],
                StartTime = new DateTime(2022, 9, 12, 16, 0, 0),
                EndTime = new DateTime(2022, 9, 12, 17, 0, 0),
                Image = "session3.png",
                Map = "map1.jpeg"
            },
        };
    }
}