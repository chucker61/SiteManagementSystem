namespace Entities.Dtos.HouseDtos
{
    public record GetByIdHouseDto : HouseDto
    {
        public int Id { get; init; }
    }
}
