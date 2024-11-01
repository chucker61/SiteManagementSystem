namespace Entities.Dtos.MembeshipDtos
{
    public record UpdateMembershipDto : MembershipDto
    {
        public int Id { get; init; }
    }
}
