using Anneleen_UsersWebAPIAdvanced2.DTO;
using Anneleen_UsersWebAPIAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Services.Interfaces
{
    public interface IPetService
    {
        void CreatePet(Pet newPet);
        Pet GetPetById(int petId);
        List<Pet> GetAllPets();
        Pet UpdatePetById(int petId, CreatePetDTO petEditValues);
        void DeletePetById(int petId);
        Pet ChangeOwner(int petId, string newOwnerId);
    }
    
}
