using Anneleen_UsersWebAPIAdvanced2.DTO;
using Anneleen_UsersWebAPIAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Services.Interfaces
{
    public interface IPersonService
    {
        void CreatePerson(Person newPerson); // CREATE
        bool Login(string email, string password); // READ
        Person ChangePassword(string email, string oldPassword, string newPassword); // UPDATE
        void DeletePerson(string email, string password); // DELETE
        List<Pet> GetMyPets(string email); // READ
        List<Person> GetAllPersons(); // READ
    }
}
