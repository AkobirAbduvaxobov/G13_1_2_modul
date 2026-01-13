using _2._4_dars.Models;

namespace _2._4_dars;

internal class Program
{
    static void Main(string[] args)
    {



        DomesticAnimal domesticAnimal = new DomesticAnimal("Rex");
        Dog dog = new Dog("Bobik");
        Console.WriteLine(dog.NickName);







        //Dog dog1 = new Dog()
        //{
        //    Color = "Black",
        //    Weight = 15,
        //    Height = 50,
        //    Speed = 30,
        //    NickName = "Zagron"
        //};

        //dog1.Sound();


        //Cat cat1 = new Cat()
        //{
        //    Color = "Black",
        //    Weight = 4,
        //    Height = 30,
        //    Speed = 20,
        //    NickName = "Mosh"
        //};
    }
}


