namespace Entities.Dtos.MembeshipDtos
{
    public record GetByIdMembershipDto : MembershipDto
    {
        public int Id { get; set; }
    }
}
