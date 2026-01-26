namespace _2._10.Extensions;

public static class UserExtensions
{
    public static int GetAge(this User user)
    {
        return 2026 - user.BirthOfDate.Year;
    }
}
