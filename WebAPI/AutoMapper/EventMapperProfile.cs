using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeWorkTask.Data.Models;
using HomeWorkTask.Shared.DTOs;

namespace WebAPI.AutoMapper
{
    public class EventMapperProfile : Profile
    {
        public EventMapperProfile()
        {
            CreateMap<Event, EventDTO>()
                .IncludeMembers(l => l.Location).ReverseMap();
            CreateMap<Location, EventDTO>()
                .IncludeMembers(u => u.User).ReverseMap();
            CreateMap<User, EventDTO>().ReverseMap();           
        }
    }
}
