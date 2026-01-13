namespace _2._4_dars.Models;

public class Car
{
    public static string Name { get; set; }
    public Guid CarId { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"Name : {Name}, CarId : {CarId}";
    }

    public void Display()
    {
        Console.WriteLine(Name);
        Console.WriteLine(CarId);
    }

    public static void Display1()
    {
        Console.WriteLine(Name);
    }


}
