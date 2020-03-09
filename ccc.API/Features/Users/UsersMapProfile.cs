using AutoMapper;
using ccc.Entity.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ccc.API.Features.Users
{
    public class UsersMapProfile : Profile
    {
        public UsersMapProfile()
        {
            CreateMap<ApplicationUser, UserModel>()
            ;

            CreateMap<UserModel, ApplicationUser>();
        }
    }
}
