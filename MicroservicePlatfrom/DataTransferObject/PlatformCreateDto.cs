using System.ComponentModel.DataAnnotations;

namespace MicroservicePlatfrom.DataTransferObject
{
    public class PlatformCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
