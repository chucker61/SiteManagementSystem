namespace Entities.Dtos.HouseDtos
{
    public record UpdateHouseDto : HouseDto
    {
        public int Id { get; init; }
    }
}
