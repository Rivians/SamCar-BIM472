using AutoMapper;
using SamCar472.Application.Features.Mediator.Commands.AppUserCommands;
using SamCar472.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamCar472.Persistence.Mappings
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateAppUserCommand, AppUser>().ReverseMap();
        }
    }
}
