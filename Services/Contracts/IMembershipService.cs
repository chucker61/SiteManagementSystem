using Entities.Dtos.HouseDtos;
using Entities.Dtos.MembeshipDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IMembershipService
    {
        Task CreateMembershipAsync(CreateMembershipDto createMembershipDto);
        Task UpdateMembershipAsync(UpdateMembershipDto updateMembershipDto);
        Task DeleteMembershipAsync(int id);
        IQueryable<ResultMembershipDto> GetAllMemberships();
    }
}
