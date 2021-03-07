using Anneleen_UsersWebAPIAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Services.Interfaces
{
    public interface IHouseService
    {
        void CreateHouse(House newHouse); //CREATE
        House GetHouseById(int houseId); // READ
        House UpdateHouseById(int houseId, CreateAndUpdateHouseDTO houseEditValues); // UPDATE
        void DeleteHouseById(int houseId); // DELETE
        List<House> GetAllHouses(); // READ
    }
}
