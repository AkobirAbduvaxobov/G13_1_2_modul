namespace _2._9_dars;

public static class IntEntensions
{
    public static int GetSummOfDigits(this int num)
    {
        int summ = 0;
        while(true)
        {
            summ += num % 10;
            num /= 10;
            if (num == 0) break;
        }

        return summ;
    }
}
