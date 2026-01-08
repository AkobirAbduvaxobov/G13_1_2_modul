using _2._3Dars.Models;

namespace _2._3Dars;

internal class Program
{
    static void Main(string[] args)
    {

        Car car = new Car("White", "Toyota kamri", 15999, "Toyota");
        new Car();
        Console.WriteLine(car.Color);
        car.Foo();


        //Car car1 = new Car()
        //{
        //    Color = "Red",
        //    Brand = "GM",
        //    Model = "Damas",
        //    Price = 8999
        //};

        //Car car2 = new Car();
        //car2.Brand = "BMW";
        //car2.Price = 25699;
        //car2.Model = "X5";
        //car2.Color = "Black";

        //Car car3 = new Car("White", "Toyota kamri", 15999, "Toyota");


    }
}