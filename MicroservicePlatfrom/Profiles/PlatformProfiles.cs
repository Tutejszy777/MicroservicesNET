using AutoMapper;
using MicroservicePlatfrom.DataTransferObject;
using MicroservicePlatfrom.Models;

namespace MicroservicePlatfrom.Profiles
{
    public class PlatformProfiles : Profile
    {
        public PlatformProfiles()
        {
            // Source -> Target
            CreateMap<Platform, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platform>();
        }
    }
}
