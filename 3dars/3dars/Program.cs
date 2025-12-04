namespace _3dars;

internal class Program
{
    static void Main(string[] args)
    {

        Console.Write("1 chis son : ");
        var num1 = int.Parse(Console.ReadLine());

        Console.Write("2 chis son : ");
        var num2 = int.Parse(Console.ReadLine());

        var num1Counter = 0;
        var num2Counter = 0;

        for (var i = 1; i <= num1; i++)
        {
            if (num1 % i == 0)
            {
                num1Counter++;
            }
        }

        for (var i = 1; i <= num2; i++)
        {
            if (num2 % i == 0)
            {
                num2Counter++;
            }
        }

        if (num1Counter == 2 && num2Counter == 2)
        {
            Console.WriteLine(num1 + num2);
        }
        else
        {
            Console.WriteLine(num1 * num2);
        }

        Main(args);





        // tub sonlar

        //Console.Write("Son kiriting : ");
        //var num = int.Parse(Console.ReadLine()); // 24
        //var counter = 0;

        //for(var i = 1; i <= num; i++)
        //{
        //    if(num % i == 0)
        //    {
        //        counter++;
        //    }
        //}

        //Console.Write($"{counter}  ");

        //if(counter == 2)
        //{
        //    Console.WriteLine("Tub");
        //}
        //else
        //{
        //    Console.WriteLine("Tub emas");
        //}

        //Main(args);



        // 24 => 




        // debugging

        //Console.Write("3 xonali son kiriting : ");
        //int num = int.Parse(Console.ReadLine());   
        //// 452
        //int r1 = num / 1 % 10;
        //int r2 = num / 10 % 10;
        //int r3 = num / 1000 % 10;

        //int res = r1+ r2 + r3;

        //Console.WriteLine($"Result : {res}");



        // compile time vs run time

        // var vs dynamic

        //dynamic num = 10;

        //num = "salom";

        //num = 57;

        //var num = 8;

        //var text = "salom";

        //text = "fcdngh";

        //var check = true;










        // do while

        //do
        //{
        //    Console.WriteLine("1");
        //    Console.WriteLine("2");
        //}
        //while (true);



        // foreach

        //string[] fruits = { "olma", "Banan", "anor", "Behi", "Nok", "Shaftoli" };

        //foreach (string fruit in fruits)
        //{
        //    int counter = 0;
        //    foreach (char ch in fruit)
        //    {
        //        if (ch == 'a' || ch == 'u'|| ch == 'i'|| ch == 'o'|| ch == 'e')
        //        {
        //            counter++;
        //        }
        //    }
        //    Console.WriteLine($"{fruit} : {counter}");
        //}







        //Random random = new Random();
        //int randomNumber = random.Next(1, 100);

        //int counter = 0;

        //while (true) // break
        //{
        //    Console.Write("Son kiriting : ");
        //    int num = int.Parse(Console.ReadLine());
        //    ++counter;
        //    if (num == randomNumber)
        //    {
        //        Console.WriteLine("Urra Urra");
        //        break;
        //    }

        //    if (counter == 6)
        //    {
        //        Console.WriteLine("Game over");
        //        Console.WriteLine($"Siz topolmagan son : {randomNumber}");
        //        break;
        //    }

        //    if (num > randomNumber)
        //    {
        //        Console.WriteLine("Kichikroq son kiriting");
        //    }

        //    else if (num < randomNumber)
        //    {
        //        Console.WriteLine("Kattaroq son kiriting");
        //    }
        //}



        // WHILE

        //int i = 1;

        //while(i <= 10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}




        /* barcha 3 xonali sonlar ichidan
         * hamma raqammi toq sonlar 
         * ekranga chiqaring
         * hamma raqami toq sonlarga misol pastda
         * 157, 335, 799, 751, 571, 333, 111, 597
         */






        //for(int i = 100; i <= 999; i++)
        //{
        //    int r1 = i / 1 % 10;
        //    int r2 = i / 10 % 10;
        //    int r3 = i / 100 % 10;

        //    if (r1 % 2 != 0 && r2 % 2 != 0 && r3 % 2 != 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}


        // Loops (for, while, do while, foreach)

        //Console.Write("1 chi sonni kiriting : ");
        //int num1 = int.Parse(Console.ReadLine());

        //Console.Write("2 chi sonni kiriting : ");
        //int num2 = int.Parse(Console.ReadLine());
        //// 16 5
        //for(int i = num1; i <= num2; i++)
        //{
        //    if (i % 3 == 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}
        //Console.WriteLine();
        //for (int i = num1; i >= num2; i--)
        //{
        //    if (i % 3 == 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}




        //for(int i = 100; i <= 200; i++)
        //{
        //    if(i % 2 == 0)
        //    {
        //        Console.Write($"{i}, ");
        //    }
        //}






        //int num = 55;

        //if(10 <= num && num <= 99)
        //{
        //    Console.WriteLine("Ikki xonali");
        //}

        /* Funksiya ichidagi o'zgaruvchilar kichik harda bo'lsin CamelCase (intValue)
         * {} alohida qatorda bo'lsin
         *
         *
         */
    }
}
