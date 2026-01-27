using _2._11_dars__Project_.Dtos;

namespace _2._11_dars__Project_.Services;

public interface IUserService
{
    public List<UserGetDto>? GetAllUsers(string token);
    public bool DeleteUser(Guid userId, string token);
    public bool DeleteUserPost(Guid postId, string token);
    public bool BlockUser(Guid userId, string token);
    public bool ChangeRole(Guid userId, string newRole, string token);
}