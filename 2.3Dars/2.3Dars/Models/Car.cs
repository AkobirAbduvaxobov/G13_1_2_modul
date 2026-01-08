namespace _2._3Dars.Models;

public class Car
{
    public Guid CarId { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public string Brand { get; set; }
    public decimal Price { get; set; }

    public Car()
    {
        Foo();
    }

    public Car(string color, string model, decimal price, string brand = "GM")
    {
        Color = color;
        Model = model;
        Brand = brand;
        Price = price;
        Foo();
    }

    public void Foo()
    {
        Console.WriteLine("Salom g13");
    }

}
