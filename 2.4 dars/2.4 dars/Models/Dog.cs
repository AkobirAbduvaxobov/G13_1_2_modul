namespace _2._4_dars.Models;

public class Dog : DomesticAnimal
{

    public Dog(string nickName) 
    {
        NickName = nickName;
        Console.WriteLine("Dog ctor ishladi");
    }
}
