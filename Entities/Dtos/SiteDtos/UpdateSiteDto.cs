namespace Entities.Dtos.SiteDtos
{
    public record UpdateSiteDto : SiteDto
    {
        public int Id { get; init; }
    }
}
