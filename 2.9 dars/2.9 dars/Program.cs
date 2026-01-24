using _2._9_dars.Extensions;

namespace _2._9_dars;

internal class Program
{
    static void Main(string[] args)
    {

        int son = 5445;
        Console.WriteLine(son.GetSummOfDigits());


        //string s = "salom5645";
        //var res = s.RemoveDigits("G13");
        //Console.WriteLine(res);
    }

}


public abstract class A
{
    public static int GetSummOfDigits();
}