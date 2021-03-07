using Anneleen_UsersWebAPIAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.DTO
{
    public class GetMyPetsDTO
    {
        public int PetId { get; set; }
        public DateTime BirthDate { get; set; }
        public EnumPetTypes PetType { get; set; }
    }
}
