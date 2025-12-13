using System.Data.SqlTypes;

namespace Dars7;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine(Foo("abXYabX"));
        Console.WriteLine(Foo("yy"));
        Console.WriteLine(Foo("zzzzz"));
        Console.WriteLine(Foo("Hello!andHello!"));
        Console.WriteLine(Foo("xavaXYZjava"));
        Console.WriteLine(Foo("ababa"));
    }

    static string Foo(string s)
    {
        // "zzzzzzzzzzzz"
        int count = 1;
        var s1 = string.Empty;
        var s2 = string.Empty;
        var res = string.Empty;
        for (int i = 0, j = s.Length - 1; i < s.Length / 2; i++, --j)
        {
            s1 = s.Substring(0, count);
            s2 = s.Substring(j, count);
            ++count;
            if(s1 == s2)
            {
                res = s1;
            }
        }

        return res;
    }
}
