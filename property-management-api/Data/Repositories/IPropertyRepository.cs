using property_management_api.Models;

namespace property_management_api.Data.Repositories
{
    public interface IPropertyRepository
    {
        Task<IEnumerable<Property>> GetAllPropertiesAsync();
        Task<Property> GetPropertyByIdAsync(int id);
        Task AddPropertyAsync(Property property);
    }
}
