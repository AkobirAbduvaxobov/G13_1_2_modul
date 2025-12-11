using Microsoft.VisualBasic.FileIO;

namespace dars6;

internal class Program
{
    static void Main(string[] args)
    {
        // Recursiya
        //Console.WriteLine(F(6));

        // F(6) = 6 + 15
        // F(5) = 5 + 10
        // F(4) = 4 + 6
        // F(3) = 3 + 3
        // F(2) = 2 + 1  
        // F(1) = 1 + 0

        Console.WriteLine(SummAB(4,8));
        Console.WriteLine(SummAB1(4,8));


    }

    static int SummAB1(int a, int b)
    {   // 4 8 => 4 5 6 7 8
        if (a == b - 1)
        {
            return 0;
        }
       
        return a + 1 + SummAB1(a + 1, b);
    }

    static int SummAB(int a, int b)
    {   // 4 8
        if (a == b)
        {
            return a;
        }

        return a + SummAB(a + 1, b);
    }

    // awkward
    static int F(int n)
    {
        if(n == 1)
        {
            return 1;
        }

        return n * F(n - 1);
    }


}
