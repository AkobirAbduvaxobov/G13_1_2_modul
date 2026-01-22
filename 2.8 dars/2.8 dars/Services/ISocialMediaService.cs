using _2._8_dars.Models;

namespace _2._8_dars.Services;

public interface ISocialMediaService
{
    public Guid Add(SocialMedia socialMedia);
    public List<SocialMedia> GetAll();
    public SocialMedia? GetById(Guid id);
    public bool Update(Guid id, SocialMedia socialMedia);
    public bool Delete(Guid id);
}
