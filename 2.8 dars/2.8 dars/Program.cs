using _2._8_dars.Models;
using _2._8_dars.Services;

namespace _2._8_dars;

internal class Program
{
    static void Main(string[] args)
    {
        var notificationService = GetNotification();    
        notificationService.SendNotification();

    }


    public static INotificationService GetNotification()
    {
        INotificationService emailNotificationService = new EmailService();
        INotificationService accauntNotificationService = new AccauntNotificationService();
        INotificationService tgNotificationService = new TgNotificationService();
        INotificationService teamsNotificationService = new TeamsService();

        return accauntNotificationService;
    }




}
