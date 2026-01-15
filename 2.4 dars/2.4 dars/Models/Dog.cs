namespace _2._4_dars.Models;

public class Dog : DomesticAnimal
{

    public Dog(string nickName) : base(nickName)
    {
        NickName = nickName;
        Console.WriteLine("Dog ctor ishladi");
    }

    public Dog()
    {
        Console.WriteLine("Dog bo'sh ctor ishladi");
    }
}
