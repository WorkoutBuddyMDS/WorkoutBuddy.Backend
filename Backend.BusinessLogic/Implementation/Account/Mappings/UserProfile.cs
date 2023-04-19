using AutoMapper;
using System;
using Backend.BusinessLogic.Account;
using Backend.Entities;

namespace WorkoutBuddy.BusinessLogic.Account
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<RegisterModel, User>()
                .ForMember(a => a.Iduser, a => a.MapFrom(s => Guid.NewGuid()))
                .ForMember(a => a.Salt, a => a.MapFrom(s => Guid.NewGuid()))
                .ForMember(a => a.Password, a => a.Ignore())
                .ForMember(a => a.Email, a => a.MapFrom(s => s.Email))
                .ForMember(a => a.Name, a => a.MapFrom(s => s.Name))
                .ForMember(a => a.BirthDate, a => a.MapFrom(s => s.BirthDay))
                .ForMember(a => a.Username, a => a.MapFrom(s => s.Username))
                .ForAllOtherMembers(a => a.Ignore());

        }
    }
}
