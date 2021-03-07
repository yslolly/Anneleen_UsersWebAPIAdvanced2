using Anneleen_UsersWebAPIAdvanced2.DTO;
using Anneleen_UsersWebAPIAdvanced2.Models;
using Anneleen_UsersWebAPIAdvanced2.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anneleen_UsersWebAPIAdvanced2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;
        public PersonController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpPost("create person")] // CREATE
        public ActionResult CreatePerson(CreatePersonDTO newPerson)
        {
            var person = _mapper.Map<Person>(newPerson);
            _personService.CreatePerson(person);
            return Ok(newPerson);
        }

        [HttpGet("login testen")] // READ
        public ActionResult<bool> Login(string email, string password)
        {
            bool succesful = _personService.Login(email, password);
            return (succesful);
        }

        [HttpGet("get all persons")] // READ
        public ActionResult<List<GetPersonWithPetsAndHouseDTO>> GetAllPersons() // todo: error op mapping
        {
            var listOfAllPersons = _personService.GetAllPersons();
            if (listOfAllPersons == null)
            {
                return NotFound();
            }
            else
            {
                var listOfAllPersonsDTO = _mapper.Map<List<GetPersonWithPetsAndHouseDTO>>(listOfAllPersons);
                return Ok(listOfAllPersonsDTO);
            }
            
        }

        [HttpPut("change password")] // UPDATE
        public ActionResult ChangePassword(string email, string oldPassword, string newPasword)
        {
            bool succesful = _personService.Login(email, oldPassword);
            if (succesful)
            {
                _personService.ChangePassword(email, oldPassword, newPasword);
                return Ok();
            }
            return StatusCode(401);
        }

        [HttpGet("get all my pets")] //READ
        public ActionResult<List<GetMyPetsDTO>> GetMyPets(string email)
        {
            var listOfAllMyPets = _personService.GetMyPets(email);
            if (listOfAllMyPets == null)
            {
                return NotFound();
            }
            else
            {
                var getMyPetsDTOList = _mapper.Map<List<GetMyPetsDTO>>(listOfAllMyPets);
                return Ok(getMyPetsDTOList);
            }
            
        }

        [HttpDelete("delete person by email")] // DELETE
        public ActionResult DeletePerson(string email, string password)
        {
            bool succesful = _personService.Login(email, password);
            if (succesful)
            {
                _personService.DeletePerson(email, password);
                return Ok();
            }
            return StatusCode(401);
        }
    }
}
