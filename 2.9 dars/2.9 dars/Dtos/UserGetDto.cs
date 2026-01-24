namespace _2._9_dars.Dtos;

public class UserGetDto
{
    public Guid UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public DateTime RegisteredTime { get; set; }
}
