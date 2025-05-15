using MicroservicePlatfrom.DataTransferObject;

namespace MicroservicePlatfrom.SyncDataServices.HTTP
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat);
    }
}
