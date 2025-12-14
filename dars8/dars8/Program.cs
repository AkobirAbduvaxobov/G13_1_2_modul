namespace dars8;

internal class Program
{
    static List<int> Ages = new List<int>();
    static void Main(string[] args)
    {
        // CRUD

        while(true)
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Read");

            Console.Write("Tanlang : ");
            int.TryParse(Console.ReadLine(), out int c);
            if(c == 1)
            {
                Console.Write("Yoshni kiriting : ");
                int.TryParse(Console.ReadLine(), out int yosh);
                CreateAge(yosh);
            }
            else if(c == 2)
            {
                Console.Write("Yoshni o'chirish : ");
                int.TryParse(Console.ReadLine(), out int yosh);
                DeleteAge(yosh);
            }
            else if(c == 3)
            {
                Console.Write("Eski Yoshni kiriting : ");
                int.TryParse(Console.ReadLine(), out int yosh1);
                Console.Write("Yangi Yoshni kiriting : ");
                int.TryParse(Console.ReadLine(), out int yosh2);
                UpdateAge(yosh1, yosh2);
            }
            else if(c == 4)
            {
                ReadAges();
            }
            Console.ReadKey();
            Console.Clear();
        }

    }

    static void CreateAge(int age)
    {
        Ages.Add(age);
    }

    static void DeleteAge(int age)
    {
        Ages.Remove(age);
    }

    static void UpdateAge(int oldAge, int newAge)
    {
        int index = Ages.IndexOf(oldAge);
        if (index != -1)
        {
            Ages[index] = newAge;
        }
    }

    static void ReadAges()
    {
        foreach (var age in Ages)
        {
            Console.WriteLine(age);
        }
        Console.WriteLine();
    }
}
