using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.DTO
{
    public class GetPersonWithPetsAndHouseDTO // todo
    {
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<GetPetIdDTO> Pets { get; set; }
        public GetHouseIdDTO HouseId { get; set; }
    }
}
