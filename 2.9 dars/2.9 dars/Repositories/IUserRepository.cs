using _2._9_dars.Entities;

namespace _2._9_dars.Repositories;

public interface IUserRepository
{
    public Guid Add(User user);
    public List<User> GetAll();
    public User? GetById(Guid id);
    public bool Delete(Guid id);
}