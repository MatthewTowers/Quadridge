using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quadridge.Models;
using Quadridge.Dtos;
using AutoMapper;

namespace Quadridge.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to Dto
            CreateMap<Client, ClientDto>();
            CreateMap<Deal, DealDto>();

            //Dto to domain
            CreateMap<ClientDto, Client>()
                .ForMember(c => c.ClientId, opt => opt.Ignore());
            CreateMap<DealDto, Deal>()
                .ForMember(d => d.DealId, opt => opt.Ignore());
        }
    }
}