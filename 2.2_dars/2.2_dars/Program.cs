using _2._2_dars.Models;
using _2._2_dars.Services;

namespace _2._2_dars;

internal class Program
{
    static void Main(string[] args)
    {
        Phone phone1 = new Phone()
        {
            Color = "Black",
            Price = 455
        };
        Phone phone2 = new Phone()
        {
            Color = "Yellow",
            Price = 705
        };

        Phone phone3 = new Phone()
        {
            Color = "Red",
            Price = 300
        };

        PhoneService phoneService = new PhoneService();

        var phone1Id = phoneService.AddPhone(phone1);
        var phone2Id = phoneService.AddPhone(phone2);
        var phone3Id = phoneService.AddPhone(phone3);

        phoneService.DeletePhone(phone2Id);

        var phones = phoneService.GetPhones();
        


    }
}
