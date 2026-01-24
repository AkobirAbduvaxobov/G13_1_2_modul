using _2._9_dars.Dtos;
using _2._9_dars.Entities;
using _2._9_dars.Repositories;

namespace _2._9_dars.Services;

public class UserService : IUserService
{
    private IUserRepository UserRepository;
    public UserService()
    {
        UserRepository = new UserRepository();
    }
    public Guid AddUser(UserCreateDto userCreateDto)
    {
        User user = new User()
        {
            UserId = Guid.NewGuid(),
            FirstName = userCreateDto.FirstName,
            LastName = userCreateDto.LastName,
            Password = userCreateDto.Password,
            UserName = userCreateDto.UserName,
            RegisteredTime = DateTime.UtcNow,
        };

        UserRepository.Add(user);
        return user.UserId;
    }

    public bool DeleteUser(Guid id)
    {
        return UserRepository.Delete(id);
    }

    public List<UserGetDto> GetAllUsers()
    {
        var users = UserRepository.GetAll();
        var usersGetDto = new List<UserGetDto>();
        foreach (var user in users)
        {
            var dto = new UserGetDto()
            {
                UserId = user.UserId,
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                RegisteredTime = user.RegisteredTime
            };

            usersGetDto.Add(dto);
        }

        return usersGetDto;
    }

    public UserGetDto? GetUserById(Guid id)
    {
        var user = UserRepository.GetById(id);

        if (user == null) return null;

        var userGetDto = new UserGetDto()
        {
            UserId = user.UserId,
            UserName = user.UserName,
            FirstName = user.FirstName,
            LastName = user.LastName,
            RegisteredTime = user.RegisteredTime
        };

        return userGetDto;
    }
}
