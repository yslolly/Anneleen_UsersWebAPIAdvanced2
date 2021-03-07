using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anneleen_UsersWebAPIAdvanced2.DTO;
using Anneleen_UsersWebAPIAdvanced2.Models;
using AutoMapper;

namespace Anneleen_UsersWebAPIAdvanced2.Profiles
{
    public class PetProfile : Profile
    {
        public PetProfile()
        {
            CreateMap<GetPetIdDTO, Pet>()
                .ReverseMap();
            CreateMap<CreatePetDTO, Pet>()
                .ReverseMap();
            CreateMap<GetMyPetsDTO, Pet>()
                .ReverseMap();
            CreateMap<GetAllPetsDTO, Pet>()
                .ReverseMap();
            CreateMap<GetAllPetsByTypeDTO, Pet>()
                .ReverseMap();
        }
    }
}
