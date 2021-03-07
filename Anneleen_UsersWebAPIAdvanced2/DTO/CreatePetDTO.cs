using Anneleen_UsersWebAPIAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.DTO
{
    public class CreatePetDTO
    {
        public DateTime BirthDate { get; set; }
        public EnumPetTypes PetType { get; set; }
        public string PersonId { get; set; }
    }
}
