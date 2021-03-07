using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.DTO
{
    public class CreatePersonDTO
    {
        public string PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public int? HouseId { get; set; }
    }
}
