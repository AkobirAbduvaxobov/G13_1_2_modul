namespace dar10;

internal class Program
{
    static void Main(string[] args)
    {

        Student student1 = new Student()
        {
            FirstName = "John",
            LastName = "Doe",
            Age = 20,
            BirthYear = 2005,
            Addess = "123 Main St",
            PhoneNumber = "555-1234",
            Grade = "A"
        };

        Student student2 = new Student()
        {
            FirstName = "Jane",
            LastName = "Smith",
            Age = 22,
            BirthYear = 4200,
            Addess = "456 Elm St",
            PhoneNumber = "555-5678",
            Grade = "B"
        };


        Student student3 = new Student()
        {
            FirstName = "Alice",
            LastName = "Johnson",
            Age = 19,
            BirthYear = 2004,
            Addess = "789 Oak St",
            PhoneNumber = "555-9012",
            Grade = "A+"
        };

        Student student4 = new Student();
        student4.FirstName = "Bob";
        student4.LastName = "Brown";
        student4.Age = 21;
        student4.BirthYear = 2003;
        student4.Addess = "321 Pine St";
        student4.PhoneNumber = "555-3456";
        student4.Grade = "C";






        //Car car2 = new Car();
        //car2.Color = "Black";
        //car2.Model = "Matiz";
        //car2.Brand = "Chevrolet";
        //car2.Weight = 900;
        //car2.ManifacturedYear = 2010;
        //car2.MaxSpeed = 180;
        //car2.HorsePower = 70;
        //car2.FuelType = "Benzin";


        //Car car1 = new Car()
        //{
        //    Color = "Red",
        //    Model = "Nexiya",
        //    Brand = "Chevrolet",
        //    Weight = 1200,
        //    ManifacturedYear = 2018,
        //    MaxSpeed = 220,
        //    HorsePower = 130,
        //    FuelType = "Benzin"
        //};

        //Console.WriteLine(car1.Color);
        //Console.WriteLine(car1.MaxSpeed);

    }
}

