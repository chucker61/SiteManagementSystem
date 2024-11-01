namespace Entities.Dtos.ApartmentDtos
{
    public record GetByIdApartmentDto : ApartmentDto
    {
        public int Id { get; init; }
    }
}
