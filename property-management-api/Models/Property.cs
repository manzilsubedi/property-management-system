namespace property_management_api.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string OwnerName { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime DateListed { get; set; }

    }
}
