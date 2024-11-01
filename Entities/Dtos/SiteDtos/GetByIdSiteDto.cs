namespace Entities.Dtos.SiteDtos
{
    public record GetByIdSiteDto : SiteDto
    {
        public int Id { get; init; }
    }
}
