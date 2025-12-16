namespace dars9;

internal class Program
{
    static void Main(string[] args)
    {




    }

    static int GetSumm(List<int> nums)
    {
        var res = 0;

        foreach (var num in nums)
        {
            res += num;
        }

        return res;
    }

    static int GetCount(List<string> words)
    {
        int counter = 0;
        foreach (var word in words)
        {
            if (word[0] == '$')
            {
                counter++;
            }
        }
        return counter;
    }
}