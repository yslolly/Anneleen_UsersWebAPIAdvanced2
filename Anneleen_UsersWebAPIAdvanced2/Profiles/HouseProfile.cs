using Anneleen_UsersWebAPIAdvanced2.DTO;
using Anneleen_UsersWebAPIAdvanced2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Anneleen_UsersWebAPIAdvanced2.Profiles
{
    public class HouseProfile : Profile
    {
        public HouseProfile()
        {
            CreateMap<GetHouseDTO, House>()
                .ReverseMap();
            CreateMap<CreateAndUpdateHouseDTO, House>()
                .ReverseMap();
            CreateMap<GetHouseWithResidentsDTO, House>()
                .ReverseMap();
            CreateMap<GetHouseIdDTO, House>()
                .ReverseMap();
            CreateMap<GetResidentsDTO, House>()
                .ReverseMap();
        }
    }
}
