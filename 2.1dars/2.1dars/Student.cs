namespace _2._1dars;

public class Student
{
    public Guid StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDate { get; set; }


    // methods

    public int CalculateAge()
    {
        DateTime now = DateTime.Now;
        int age = now.Year - BirthDate.Year;
        return age;
    }

    public void HelloG13()
    {
        Console.WriteLine("Hello G13 from Student class");
    }

    public void PrintPhone()
    {
        Console.WriteLine($"Student Phone: {Phone}");
    }

    public void PrintStudentId()
    {
        Console.WriteLine($"Student ID: {StudentId}");
    }

    public void PrintAllInfo()
    {
        Console.WriteLine($"ID : {StudentId}");
        Console.WriteLine($"FN : {FirstName}");
        Console.WriteLine($"LN : {LastName}");
        Console.WriteLine($"Email : {Email}");
        Console.WriteLine($"Phone : {Phone}");
    }

    public int GetFullNameLength()
    {
        return (FirstName + LastName).Length;
    }

    override public string ToString()
    {
        return $"ID : {StudentId}\nFN : {FirstName}\nLN : {LastName}\nEmail : {Email}\nPhone : {Phone}";
    }
}
