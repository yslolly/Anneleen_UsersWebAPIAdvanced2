using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public DateTime BirthDate { get; set; }
        public EnumPetTypes PetType { get; set; }
        public string PersonId { get; set; } // todo: foreign key constraint failed
        [Required]
        public Person PetOwner { get; set; }
    }

    public enum EnumPetTypes
    {
        hond,
        kat,
        cavia,
        goudvis
    }
}
