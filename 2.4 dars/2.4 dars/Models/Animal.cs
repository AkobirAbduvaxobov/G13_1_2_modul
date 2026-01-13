namespace _2._4_dars.Models;

public class Animal
{
    public string Color { get; set; }
    public double Speed { get; set; }
    public double Weight { get; set; }
    public double Height { get; set; }

    public Animal()
    {
        Console.WriteLine("Animal ctor ishladi");
    }

    public void Sound()
    {
        Console.WriteLine("Ovoz chiqaradi");
    }
}
