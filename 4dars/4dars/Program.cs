namespace _4dars;

internal class Program
{

    // return type

    static string RemoveDigits(string str) // 
    {
        // "S2L45trg8"
        for (var i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i]))
            {
                str = str.Remove(i, 1);
                i--;
            }
        }
        return str;
    }


    static int GetCountOfCapitalLetter(string s)
    {
        int count = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsUpper(s[i]))
            {
                count++;
            }
        }

        return count;
    }




    static void Main(string[] args)
    {

        var str = "Salom Dunyo! Hello World! G13 .net";

        Console.WriteLine(GetCountOfCapitalLetter(str));


        //var s = "Nma Gap";

        //var res = s.ToUpper();

        //Console.WriteLine(res); 
        //Console.WriteLine(s); 

        //var res = RemoveDigits("S2L45trg8");

        //Console.WriteLine(res);

        //char.IsLetter(); // harflikga tekshiradi
        //char.IsDigit(); // raqamlikka tekshiradi
        //char.IsWhiteSpace(); // bo'sh joyga tekshiradi
        //char.IsUpper(); // katta harfga tekshiradi
        //char.IsLower(); // kichik harfga tekshiradi



        //var str = ""; // string.Empty
        //var str1 = string.Empty;

        //if("" == string.Empty)
        //{
        //    Console.WriteLine("dskjfv");
        //}

        // IndexOf

        //string str = "Hello World World World";

        //var res1 = str.IndexOf("World");
        //var res2 = str.IndexOf("World", 7);
        //var res3 = str.IndexOf("jdfh");

        //Console.WriteLine(res1);
        //Console.WriteLine(res2);
        //Console.WriteLine(res3);





        // Trim

        //string str = "****Hello ** fd ** World*****";

        //var res = str.Trim('*');

        //Console.WriteLine(res);
        //Console.WriteLine(str);


        // Contains

        //string str = "Hello World World World";

        //var res = str.Contains("ds");

        //Console.WriteLine(res);



        // Remove

        //var str = "Uzbekiston";

        //var res = str.Remove(0,20);

        //Console.WriteLine(str);
        //Console.WriteLine(res);



        //string str = "G13 .net";

        //var len = str.Length;

        //Console.WriteLine(len);


        // 1. satr berilgan oxiridan 3 ta belgini ekranga chiqaring
        // TestCase
        // Input: "Foundation"  output: "ion"
        // Input: "davay"  output: "vay"

        //string str = "davay";

        //var res = str.Substring(str.Length - 3);
        //Console.WriteLine(res);



        // 2. satr berilgan oxiridan oxiridan 2 ta boshidan 2 ta 
        // olmasdan o'rtadagi belgilarni chiqaring
        // TestCase
        // Input: "Foundation"  output: "undati"
        // Input: "davay"  output: "v"


        //string str = "Foundation";

        //var res = str.Substring(2, str.Length - 4);
        //Console.WriteLine(res);

        // string

        //string text = "salom Hello g13";

        //// Substring

        //var res2 = text.Substring(0);

        //Console.WriteLine(res2);

        //var res1 = text.Substring(6, 5);
        //Console.WriteLine(res1);
        //Console.WriteLine(text);

    }

 

}
