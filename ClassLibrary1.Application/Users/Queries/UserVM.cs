using AutoMapper;
using ClassLibrary1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1.Application.Users.Queries
{
    public class UserVM : IMapFrom<User>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int CountOfLoginHistory { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<User, UserVM>()
                .ForMember(a => a.CountOfLoginHistory, a => a.MapFrom(b => b.LoginHistories.Count()));
        }
    }
}
