using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using property_management_api.Data.Repositories;
using property_management_api.Models;

namespace property_management_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyRepository _propertyRepository;
        public PropertyController(IPropertyRepository propertyRepository = null)
        {
            _propertyRepository = propertyRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Property>>> GetProperties()
        {
            var properties = _propertyRepository.GetAllPropertiesAsync();
            return Ok(properties);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Property>> GetProperty(int id)
        {
            var property = _propertyRepository.GetPropertyByIdAsync(id);
            return Ok(property);
        }

        [HttpPost]
        public async Task<ActionResult> AddProperty([FromBody] Property property)
        {
            await _propertyRepository.AddPropertyAsync(property);
            return Ok();
        }
    }
}
