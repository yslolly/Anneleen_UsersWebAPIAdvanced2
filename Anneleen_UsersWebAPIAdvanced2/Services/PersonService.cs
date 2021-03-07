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
    public class PersonService : IPersonService
    {
        public Person ChangePassword(string email, string oldPassword, string newPassword) // UPDATE
        {
            using (var db = new UserDbContext())
            {
                var person = db.Persons.Find(email);
                if (person != null)
                {
                    if (person.Password == oldPassword)
                    {
                        person.Password = newPassword;
                    }
                }
                db.SaveChanges();
                return person;
            }
        }

        public void CreatePerson(Person newPerson) // CREATE
        {
            using (var db = new UserDbContext())
            {
                db.Persons.Add(newPerson);
                db.SaveChanges();
            }
        }

        public void DeletePerson(string email, string password) // DELETE
        {
            using (var db = new UserDbContext())
            {
                var personToDelete = db.Persons.Find(email);
                if (personToDelete != null)
                {
                    db.Persons.Remove(personToDelete);
                    db.SaveChanges();
                }
            }
        }

        public List<Person> GetAllPersons()
        {
            using (var db = new UserDbContext())
            {
                var listOfAllPersons = db.Persons.Include(x => x.House).Include(x => x.Pets).ToList();
                return listOfAllPersons;
            }
        }

        public List<Pet> GetMyPets(string personId) // READ
        {
            using (var db = new UserDbContext())
            {
                var person = db.Persons.Find(personId);
                return person.Pets;
            }
        }

        public bool Login(string email, string password) // READ
        {
            using (var db = new UserDbContext())
            {
                var person = db.Persons.Find(email);
                if (person != null)
                {
                    if (person.Password == password)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
