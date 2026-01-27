using _2._11_dars__Project_.Entities;

namespace _2._11_dars__Project_.Persistence;

public class AppDBContext
{
    public static List<User> Users { get; set; }
    public static List<Post> Posts { get; set; }
    static AppDBContext()
    {
        Users = new List<User>();
        Posts = new List<Post>();
    }
    public static (string userId, string role) GetTokenInfo(string token)
    {
        var userId = token.Substring(0, 26);
        var role = token.Substring(26);

        return (userId, role);
    }
}
