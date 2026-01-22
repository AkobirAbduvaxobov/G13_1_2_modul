using _2._8_dars.Models;
using _2._8_dars.Services;

namespace _2._8_dars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailService emailService = new EmailService();
            emailService.SendNotification();

            TeamsService teamsService = new TeamsService();
            teamsService.SendNotification();



        }


    }
}
