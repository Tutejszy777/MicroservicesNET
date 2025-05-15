using AutoMapper;
using MicroservicePlatfrom.DataTransferObject;
using MicroservicePlatfrom.Models;
using MicroservicePlatfrom.Repositories;
using MicroservicePlatfrom.SyncDataServices.HTTP;
using Microsoft.AspNetCore.Mvc;

namespace MicroservicePlatfrom.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly IPlatformRepo _repository;
        private readonly IMapper _mapper;
        private readonly ICommandDataClient _commandDataClient;

        public PlatformController(IPlatformRepo repository, IMapper mapper, ICommandDataClient commandDataClient)
        {
            _repository = repository;
            _mapper = mapper;
            _commandDataClient = commandDataClient;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            Console.WriteLine("--> Getting Platforms...");

            var platformItems = _repository.GetAllPlatforms();

            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(platformItems));
        }

        [HttpGet("{id}", Name = "GetPlatformById")]
        public ActionResult<PlatformReadDto> GetPlatformById(int id)
        {
            Console.WriteLine($"--> Getting Platform with id {id}...");
            var platformItem = _repository.GetPlatformById(id);
            if (platformItem != null)
            {
                return Ok(_mapper.Map<PlatformReadDto>(platformItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platformCreate)
        {
            var platform = _mapper.Map<Platform>(platformCreate);
            _repository.CreatePlatform(platform);
            _repository.SaveChanges();

            var plarformRead = _mapper.Map<PlatformReadDto>(platform);

            return CreatedAtRoute(nameof(GetPlatformById), new { Id = plarformRead.Id }, plarformRead);
        }
    }
}
