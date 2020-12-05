using Assignment.Entity.Entities.BusinessEntities;
using Assignment.Entity.Entities.DataEntities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Service.MappingProfiles
{
    /// <summary>
    /// Profile For Automapper
    /// </summary>
    /// <seealso cref="AutoMapper.Profile" />
    public class AutoMapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutomapperProfile"/> class.
        /// Holds Mapping Pair Configurations
        /// </summary>
        public AutoMapperProfile()
        {
            CreateMap<TblUser, UserViewModel>();
            CreateMap<UserViewModel, TblUser>().ForMember( x => x.Role, opt => opt.Ignore());
        }
    }
}
