using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Models
{
    public class House
    {
        public int HouseId { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public List<Person> Residents { get; set; } // hier geen rekening mee houden
        // als je house wil updaten
    }
}
