// usunięcie nieużywanych usingów Ctrl+R,G

using System;

namespace Pocztowy.Models
{
    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }

    }

    public class AddressDTO
    {
        public AddressDTO(string city, string street)
        {
            City = city ?? throw new ArgumentNullException(nameof(city));
            Street = street ?? throw new ArgumentNullException(nameof(street));
        }

        public string City { get; }
        public string Street { get; }

    }
}
