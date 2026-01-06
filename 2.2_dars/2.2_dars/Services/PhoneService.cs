using _2._2_dars.Models;

namespace _2._2_dars.Services;

public class PhoneService
{
    public List<Phone> Phones = new List<Phone>();

    public Guid AddPhone(Phone phone)
    {
        phone.PhoneId = Guid.NewGuid();
        Phones.Add(phone);
        return phone.PhoneId;
    }

    public List<Phone> GetPhones()
    {
        return Phones;
    }

    public bool DeletePhone(Guid phoneId)
    {
        foreach(var phone in Phones)
        {
            if(phone.PhoneId == phoneId)
            {
                Phones.Remove(phone);
                return true;
            }
        }

        return false;
    }

}
