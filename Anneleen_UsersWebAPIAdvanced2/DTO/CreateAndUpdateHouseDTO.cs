using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2
{
    public class CreateAndUpdateHouseDTO
    {
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
