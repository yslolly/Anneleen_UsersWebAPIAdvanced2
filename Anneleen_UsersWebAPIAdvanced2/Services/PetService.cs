using Anneleen_UsersWebAPIAdvanced2.Db;
using Anneleen_UsersWebAPIAdvanced2.DTO;
using Anneleen_UsersWebAPIAdvanced2.Models;
using Anneleen_UsersWebAPIAdvanced2.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Services
{
    public class PetService : IPetService
    {
        public Pet ChangeOwner(int petId, string emailNewOwner) // UPDATE
        {
            using(var db = new UserDbContext())
            {
                var petToUpdate = db.Pets.Find(petId);
                if (petToUpdate != null)
                {
                    petToUpdate.PersonId = emailNewOwner;
                    db.Update(petToUpdate);
                    db.SaveChanges();
                }
                return petToUpdate;
            }
        }

        public void CreatePet(Pet newPet) // CREATE
        {
            using(var db = new UserDbContext())
            {
                db.Pets.Add(newPet); // todo: foreign key constraint failed
                db.SaveChanges();
            }
        }

        public void DeletePetById(int petId) // DELETE
        {
            using (var db = new UserDbContext())
            {
                var petToDelete = db.Pets.Find(petId);
                if (petToDelete != null)
                {
                    db.Pets.Remove(petToDelete);
                    db.SaveChanges();
                }
            }
        }

        public List<Pet> GetAllPets() // READ
        {
            using (var db = new UserDbContext())
            {
                var listOfAllPets = db.Pets.Include(x => x.PetOwner).ToList();
                return listOfAllPets;
            }
        }

        public Pet GetPetById(int petId) // READ
        {
            using (var db = new UserDbContext())
            {
                var petToFind = db.Pets.Find(petId);
                return petToFind;
            }
        }

        public Pet UpdatePetById(int petId, CreatePetDTO petEditValues) // UPDATE
        {
            using(var db = new UserDbContext())
            {
                var petToUpdate = db.Pets.Find(petId);
                petToUpdate.BirthDate = petEditValues.BirthDate;
                petToUpdate.PersonId = petEditValues.PersonId;
                petToUpdate.PetType = petEditValues.PetType;
                db.Update(petToUpdate);
                db.SaveChanges();
                return petToUpdate;
            }
        }
    }
}
