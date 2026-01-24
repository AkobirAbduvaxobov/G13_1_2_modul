using _2._9_dars.Dtos;

namespace _2._9_dars.Services;

public interface IUserService
{
    public Guid AddUser(UserCreateDto userCreateDto);
    public List<UserGetDto> GetAllUsers();
    public UserGetDto? GetUserById(Guid id);
    public bool DeleteUser(Guid id);
}