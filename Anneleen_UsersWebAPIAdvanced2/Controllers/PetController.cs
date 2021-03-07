using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Anneleen_UsersWebAPIAdvanced2.Services.Interfaces;
using Anneleen_UsersWebAPIAdvanced2.Models;
using Anneleen_UsersWebAPIAdvanced2.DTO;

namespace Anneleen_UsersWebAPIAdvanced2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetService _petService;
        private readonly IMapper _mapper;
        public PetController(IPetService petservice, IMapper mapper)
        {
            _petService = petservice;
            _mapper = mapper;
        }

        [HttpGet("get pet by id")] // READ
        public ActionResult<CreatePetDTO> GetPetById(int petId)
        {
            var petToFind = _petService.GetPetById(petId);
            if (petToFind == null)
            {
                return NotFound();
            }
            else
            {
                var petToFindDTO = _mapper.Map<CreatePetDTO>(petToFind);
                return Ok(petToFindDTO);
            }
        }

        [HttpGet("get all pets")] // READ
        public ActionResult<Pet> GetAllPets()
        {
            var listOfAllPets = _petService.GetAllPets();
            var listOfAllPetsDTO = _mapper.Map<GetAllPetsDTO>(listOfAllPets); // todo: error op mapping
            return Ok(listOfAllPetsDTO);
        }

        [HttpGet("get all pets by type")] // READ
        public ActionResult<GetAllPetsByTypeDTO> GetAllPetsByType(EnumPetTypes petType)
        {
            var listOfAllPets = _petService.GetAllPets();
            var listOfAllPetsByTypeDTO = new List<GetAllPetsByTypeDTO>();
            foreach (var pet in listOfAllPets)
            {
                if (pet.PetType == petType)
                {
                    var petDTO = _mapper.Map<GetAllPetsByTypeDTO>(pet);
                    listOfAllPetsByTypeDTO.Add(petDTO);
                }
            }
            return Ok(listOfAllPetsByTypeDTO);
        }

        [HttpPost("create pet")] // CREATE
        public ActionResult CreatePet(CreatePetDTO newPetDTO)
        {
            var newPet = _mapper.Map<Pet>(newPetDTO);
            _petService.CreatePet(newPet);
            return Ok();
        }

        [HttpPut("update pet")] // UPDATE
        public ActionResult<CreatePetDTO> UpdatePet(int petId, CreatePetDTO petEditValues)
        {
            var updatedPet = _petService.UpdatePetById(petId, petEditValues);
            var updatedPetDTO = _mapper.Map<CreatePetDTO>(updatedPet);
            return updatedPetDTO;
        }

        [HttpPut("change owner")]
        public ActionResult ChangeOwner(int petId, string newOwnerEmail)
        {
            _petService.ChangeOwner(petId, newOwnerEmail);
            return Ok();
        }

        [HttpDelete("delete pet by id")] // DELETE
        public ActionResult DeletePetById(int petId)
        {
            _petService.DeletePetById(petId);
            return Ok();
        }

    }
}
