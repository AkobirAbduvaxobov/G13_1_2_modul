namespace _2._10.Extensions;

public static class StringExtensions
{
    public static (char, char, int, string, string) GetInfo(this string s)
    {
        return (s[0], s[s.Length - 1], s.Length,
            s.Substring(0, 3), s.Substring(s.Length - 3));
    }

    public static int GetCountOfCat1(this string text)
    {
        var catCounter = 0; // "catcat salom cat" 
        var index = -1;
        while(true)
        {
            index = text.IndexOf("cat", index + 1); // 0, 3, 13, -1
            if(index == -1)
            {
                break;
            }
            ++catCounter; // 1, 2, 3
        }

        return catCounter;
    }

    public static int GetCountOfCat2(this string text)
    {
        // salom cat ok cat salom
        // {"salom ", " ok ", " salom"}
        var arr = text.Split("cat");
        return arr.Length - 1;
    }

    public static int GetCountOfCat3(this string text)
    {
        var catCounter = 0;
        for(var i = 0; i < text.Length - 2; i++)
        {
            if (text[i] == 'c' && text[i+1] == 'a' 
                && text[i+ 2] == 't')
            {
                ++catCounter;
            }
        }

        return catCounter;
    }


}
