namespace Entities.Dtos.ApartmentDtos
{
    public record UpdateApartmentDto : ApartmentDto
    {
        public int Id { get; init; }
    }
}
