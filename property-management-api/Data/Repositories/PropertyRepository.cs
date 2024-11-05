using property_management_api.Models;

namespace property_management_api.Data.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ApplicationDbContext _context;
        public PropertyRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public Task AddPropertyAsync(Property property)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Property>> GetAllPropertiesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Property> GetPropertyByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
