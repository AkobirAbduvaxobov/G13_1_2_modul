using _2._8_dars.Models;

namespace _2._8_dars.Services;

public class SMAzureService : ISocialMediaService
{
    List<SocialMedia> SocialMediasAzure = new List<SocialMedia>();
    public Guid Add(SocialMedia socialMedia)
    {
        socialMedia.SocialMediaId = Guid.NewGuid();
        SocialMediasAzure.Add(socialMedia);
        return socialMedia.SocialMediaId;
    }

    public bool Delete(Guid id)
    {
        foreach (var sM in SocialMediasAzure)
        {
            if (sM.SocialMediaId == id)
            {
                SocialMediasAzure.Remove(sM);
                return true;
            }
        }
        return false;
    }

    public List<SocialMedia> GetAll()
    {
        return SocialMediasAzure;
    }

    public SocialMedia? GetById(Guid id)
    {
        foreach (var sM in SocialMediasAzure)
        {
            if (sM.SocialMediaId == id)
            {
                return sM;
            }
        }

        return null;
    }

    public bool Update(Guid id, SocialMedia socialMedia)
    {
        foreach (var sM in SocialMediasAzure)
        {
            if (sM.SocialMediaId == id)
            {
                sM.Name = socialMedia.Name;
                sM.Description = socialMedia.Description;
                sM.Ceo = socialMedia.Ceo;
                return true;
            }
        }

        return false;
    }
}
