using _2._11_dars__Project_.Dtos;

namespace _2._11_dars__Project_.Services;

public interface IAuthService
{
    public Guid RegisterUser(UserRegisterDto userRegisterDto);
    public string LoginUser(UserLoginDto userLoginDto);
}