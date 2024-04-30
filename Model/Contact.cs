namespace MarketManager.Model
{
    public class Contact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }

        public Contact(string name, string email, string phone, string address, string country, string city, string region, string postalCode)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
            Country = country;
            City = city;
            Region = region;
            PostalCode = postalCode;
        }
    }
}
