using AutoMapper;
using WebApplication1.Models;
using WebApplication1.Models.Create;

namespace WebApplication1.Profiles
{
    public class MappingProfile_00013540 : Profile
    {
        public MappingProfile_00013540()
        {
            CreateMap<UserTask_00013540, CreateUserTask_00013540>().ReverseMap();
        }
    }
}