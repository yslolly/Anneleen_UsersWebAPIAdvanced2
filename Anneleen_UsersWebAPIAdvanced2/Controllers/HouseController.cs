using Anneleen_UsersWebAPIAdvanced2.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Anneleen_UsersWebAPIAdvanced2.Models;
using Anneleen_UsersWebAPIAdvanced2.DTO;

namespace Anneleen_UsersWebAPIAdvanced2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;
        private readonly IMapper _mapper;
        public HouseController(IHouseService houseservice, IMapper mapper)
        {
            _houseService = houseservice;
            _mapper = mapper;
        }

        [HttpPost("create house")] // CREATE
        public ActionResult CreateHouse(CreateAndUpdateHouseDTO newHouseDTO)
        {
            var newHouse = _mapper.Map<House>(newHouseDTO);
            _houseService.CreateHouse(newHouse);
            return Ok();
        }

        [HttpGet("get one house by id")] // READ
        public ActionResult<GetHouseWithResidentsDTO> GetHouseById(int houseId)
        {
            var house = _houseService.GetHouseById(houseId);
            if (house == null)
            {
                return NotFound();
            }
            else
            {
                var houseDTO = _mapper.Map<GetHouseWithResidentsDTO>(house);
                return Ok(houseDTO);
            }
            
        }

        [HttpGet("get all houses by postal code")] // READ
        public ActionResult<List<GetHouseDTO>> GetAllHousesByPostalCode(string postalCode)
        {
            var listOfAllHouses = _houseService.GetAllHouses();
            var listOfAllHousesByPostalCodeDTO = new List<GetHouseDTO>();
            if (listOfAllHouses == null)
            {
                return NotFound();
            }
            else
            {
                foreach (var house in listOfAllHouses) // todo: of hier rechtstreeks met List mappen?
                {
                    if (house.PostalCode == postalCode)
                    {
                        var houseFound = _mapper.Map<GetHouseDTO>(house);
                        listOfAllHousesByPostalCodeDTO.Add(houseFound);
                    }
                }
                return Ok(listOfAllHousesByPostalCodeDTO);
            }
            
        }

        [HttpPut("update house by id")] // UPDATE 
        public ActionResult<GetHouseDTO> UpdateHouseById(int houseId, CreateAndUpdateHouseDTO houseEditValues)
        {
            var house = _houseService.UpdateHouseById(houseId, houseEditValues);
            var houseDTO = _mapper.Map<GetHouseDTO>(house);
            return houseDTO;
        }


        [HttpDelete("delete house by id")] // DELETE
        public ActionResult DeleteHouseById(int houseId)
        {
            var house = _houseService.GetHouseById(houseId);
            if (house == null)
            {
                return NotFound();
            }
            else
            {
                _houseService.DeleteHouseById(houseId);
                return Ok();
            }
            
        }
    }
}
