using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.DTO
{
    public class GetHouseWithResidentsDTO
    {
        public int HouseId { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        List<GetResidentsDTO> Residents { get; set; }
    }
}
