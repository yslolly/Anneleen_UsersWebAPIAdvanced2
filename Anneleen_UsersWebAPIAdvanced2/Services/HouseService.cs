using Anneleen_UsersWebAPIAdvanced2.Db;
using Anneleen_UsersWebAPIAdvanced2.Models;
using Anneleen_UsersWebAPIAdvanced2.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Services
{
    public class HouseService : IHouseService
    {
        public void CreateHouse(House newHouse) // CREATE
        {
            using (var db = new UserDbContext())
            {
                db.Houses.Add(newHouse);
                db.SaveChanges();
            }
        }

        public void DeleteHouseById(int houseId) // DELETE
        {
            using (var db = new UserDbContext())
            {
                var houseToDelete = db.Houses.Find(houseId);
                if (houseToDelete != null)
                {
                    db.Houses.Remove(houseToDelete);
                    db.SaveChanges();
                }
            }
        }

        public List<House> GetAllHouses() // READ
        {
            using (var db = new UserDbContext())
            {
                var listOfAllHouses = db.Houses.ToList();
                return listOfAllHouses;
            }
        }

        public House GetHouseById(int houseId) // READ
        {
            using (var db = new UserDbContext())
            {
                var house = db.Houses.Find(houseId);
                return house;
            }

        }

        public House UpdateHouseById(int houseId, CreateAndUpdateHouseDTO houseEditValues) // UPDATE
        {
            using (var db = new UserDbContext())
            {
                var houseToUpdate = db.Houses.Find(houseId);
                if (houseToUpdate != null)
                {
                    houseToUpdate.Street = houseEditValues.Street;
                    houseToUpdate.HouseNumber = houseEditValues.HouseNumber;
                    houseToUpdate.PostalCode = houseEditValues.PostalCode;
                    houseToUpdate.City = houseEditValues.City;
                    db.Houses.Update(houseToUpdate);
                    db.SaveChanges();
                }
                return houseToUpdate;
            }
        }
    }
}

