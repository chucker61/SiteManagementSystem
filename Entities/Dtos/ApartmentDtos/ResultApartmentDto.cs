using Entities.Models;

namespace Entities.Dtos.ApartmentDtos
{
    public record ResultApartmentDto : ApartmentDto
    {
        public int Id { get; init; }
        public List<House> Houses { get; init; } = new();
    }
}
