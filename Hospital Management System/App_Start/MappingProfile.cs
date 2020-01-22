using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HMS.Models;
using HMS.ViewModels;

namespace HMS.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Domain to DTO
            Mapper.CreateMap<Room, RoomFormViewModel>();
            Mapper.CreateMap<Patient, PatientFormViewModel>();

            //DTO to Domain
            Mapper.CreateMap<RoomFormViewModel, Room>()
                .ForMember(r => r.Id, opt => opt.Ignore());

            Mapper.CreateMap<PatientFormViewModel, Patient>()
                .ForMember(p => p.Id, opt => opt.Ignore());
        }
    }
}