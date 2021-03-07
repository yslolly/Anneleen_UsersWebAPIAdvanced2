using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anneleen_UsersWebAPIAdvanced2.DTO;
using Anneleen_UsersWebAPIAdvanced2.Models;
using AutoMapper;

namespace Anneleen_UsersWebAPIAdvanced2.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<CreatePersonDTO, Person>()
                .ReverseMap();
            CreateMap<GetMyPetsDTO, Person>()
                .ReverseMap();
            CreateMap<ChangePasswordDTO, Person>()
                .ReverseMap();
            CreateMap<GetResidentsDTO, Person>()
                .ReverseMap();
            CreateMap<GetPersonWithPetsAndHouseDTO, Person>()
                .ReverseMap();
            CreateMap<GetPersonEmail, Person>()
                .ReverseMap();
        }
    }
}
