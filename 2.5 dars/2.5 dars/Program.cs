using _2._5_dars.Models;
using _2._5_dars.Services;

namespace _2._5_dars;

internal class Program
{
    static void Main(string[] args)
    {

        IStudentService studentService = new StudentService();
        Student student = new Student()
        {
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(2000, 1, 1)
        };

        Guid studentId = studentService.AddStudent(student);



        //Dog dog = new Dog();
        //dog.MakeSound();
        //dog.NafasOladi();

        //Cat cat = new Cat();
        //cat.MakeSound();
        //cat.NafasOladi();

        //BookService bookService = new BookService();
        //bookService.GetBooks();
        //bookService.AddBook();
        //bookService.DeleteBook();


    }
}
