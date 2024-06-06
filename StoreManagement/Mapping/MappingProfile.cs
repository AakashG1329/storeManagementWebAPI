using AutoMapper;
using StoreManagement.Command.Users.CreateUser;
using StoreManagement.Command.Users.UpdateUser;
using StoreManagement.Models;

namespace StoreManagement.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateUserCommand, User>();
            
        }
    }
}
