using MicroservicePlatfrom.Models;

namespace MicroservicePlatfrom.Repositories
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform plat);
        bool PlatformExists(int platformId);
    }
}