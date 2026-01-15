using _2._5_dars.Models;

namespace _2._5_dars.Services;

public interface ICountryService
{
    public Guid AddCountry(Country country);
    public bool UpdateCountry(Country country);
    public bool DeleteCountry(Guid countryId);
    public Country? GetCountryById(Guid countryId);
    public List<Country> GetAllCountries();
}
