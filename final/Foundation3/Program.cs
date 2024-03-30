using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        OutdoorGathering gathering = new("Cindy and Brett's Wedding", "Cindy and Brett are getting married!!", "3-29-24", "0900", new Address("456 Max St.", "Gotham", "NY", "US"), Weather.Clear);

        Console.WriteLine("\n\nShort Description: \n\n");
        Console.WriteLine(gathering.ShortDescription() + "\n\n");
        Console.WriteLine("Standard Details: \n\n");
        Console.WriteLine(gathering.StandardDetails() + "\n\n");
        Console.WriteLine("Full Details: \n\n");
        Console.WriteLine(gathering.FullDetails() + "\n\n");

        Reception reception = new("Cindy and Brett's Wedding Reception", "Cindy and Brett are celebrating getting married and want to see you there!!", "3-29-24", "1700", new Address("8576 Party Blvd.", "Gotham", "NY", "US"), "RSVP at this email: Cindyisgettingmarried!!!@hotmail.com");

        Console.WriteLine("Short Description: \n\n");
        Console.WriteLine(reception.ShortDescription() + "\n\n");
        Console.WriteLine("Standard Details: \n\n");
        Console.WriteLine(reception.StandardDetails() + "\n\n");
        Console.WriteLine("Full Details: \n\n");
        Console.WriteLine(reception.FullDetails() + "\n\n");
        
        Lecture lecture = new("TedTalk", "A special guest will be speaking on the importance of daily exercise","3-30-24", "1300", new Address("8364 Dummy Ave", "Pineapple", "Kingdom Come", "US"), "Goofy", 1000);

        Console.WriteLine("Short Description: \n\n");
        Console.WriteLine(lecture.ShortDescription() + "\n\n");
        Console.WriteLine("Standard Details: \n\n");
        Console.WriteLine(lecture.StandardDetails() + "\n\n");
        Console.WriteLine("Full Details: \n\n");
        Console.WriteLine(lecture.FullDetails() + "\n\n");
    }
}