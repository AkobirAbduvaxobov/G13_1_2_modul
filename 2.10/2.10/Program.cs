using _2._10.Extensions;

namespace _2._10;

internal class Program
{
    static void Main(string[] args)
    {

        // touple

        var res = Foo(1,2,3,4);
        Console.WriteLine(res.max);
        Console.WriteLine(res.min);
        Console.WriteLine(res.mult);
        Console.WriteLine(res.sum);



        //var s = "salom";
        //(string, int) res = GetIt(s);
        //Console.WriteLine(res.Item1);
        //Console.WriteLine(res.Item2);


        //string s1 = "cat catcat salom cat ";
        //string s2 = "salom cat salom ";
        //string s3 = "Cat Cat ok";

        //Console.WriteLine(s1.GetCountOfCat1());
        //Console.WriteLine(s2.GetCountOfCat1());
        //Console.WriteLine(s3.GetCountOfCat1());

        //Console.WriteLine(s1.GetCountOfCat2());
        //Console.WriteLine(s2.GetCountOfCat2());
        //Console.WriteLine(s3.GetCountOfCat2());

        //Console.WriteLine(s1.GetCountOfCat3());
        //Console.WriteLine(s2.GetCountOfCat3());
        //Console.WriteLine(s3.GetCountOfCat3());
    }

    public static (int max, int min, int sum, int mult) Foo(int a, int b, int c, int d)
    {
        var maxx = Math.Max(Math.Max(a, b), Math.Max(c, d));
        var minn = Math.Min(Math.Min(a, b), Math.Min(c, d));
        var summ = a + b + c + d;
        var multiply = a * b * c * d;
        return (maxx, minn, summ, multiply);
    }

    public static (string, int) GetIt(string text)
    {
        var count = 0;
        var vowels = string.Empty;

        foreach (var ch in text)
        {
            if(IsVowel(ch) == true)
            {
                ++count;
                vowels += ch;
            }
        }

        //var allVowels = "AaUuIiOoEe";
        //foreach (var ch in text)
        //{
        //    if (allVowels.Contains(ch) == true)
        //    {
        //        ++count;
        //        vowels += ch;
        //    }
        //}

        return (vowels, count);
    }
    public static bool IsVowel(char c)
    {
        if(c == 'a' || c == 'A') return true;   
        if(c == 'i' || c == 'I') return true;   
        if(c == 'o' || c == 'O') return true;   
        if(c == 'u' || c == 'U') return true;   
        if(c == 'e' || c == 'E') return true;

        return false;
    }

}
