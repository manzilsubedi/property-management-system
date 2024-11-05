using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
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
        public async Task AddPropertyAsync(Property property)
        {
            await _context.AddAsync(property);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Property>> GetAllPropertiesAsync()
        {
            return await _context.Properties.ToListAsync();
        }

        public async Task<Property> GetPropertyByIdAsync(int id)
        {
            var property = await _context.Properties.FindAsync(id);
            if (property == null)
            {
                return null;
            }
            return property;
        }
    }
}
