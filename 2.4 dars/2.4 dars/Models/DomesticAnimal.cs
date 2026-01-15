namespace _2._4_dars.Models;

public class DomesticAnimal : Animal
{
    public string NickName { get; set; }

    public DomesticAnimal(string nickName) 
    {
        NickName = nickName;
        Console.WriteLine("Domestik animal ctor ishladi");
    }
    public DomesticAnimal() : base("black")
    {
        Console.WriteLine("Domestik bo'sh ctor ishladi");
    }
}
