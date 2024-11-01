using AutoMapper;
using Entities.Dtos.HouseDtos;
using Entities.Dtos.MembeshipDtos;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MembershipManager : IMembershipService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public MembershipManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task CreateMembershipAsync(CreateMembershipDto createMembershipDto)
        {
            var membership = _mapper.Map<Entities.Models.Membership>(createMembershipDto);
            _repositoryManager.MembershipRepository.CreateMembership(membership);
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteMembershipAsync(int membershipId)
        {
            var membership = await _repositoryManager.MembershipRepository.GetMembershipByIdAsync(membershipId);
            _repositoryManager.MembershipRepository.DeleteMembership(membership);
            await _repositoryManager.SaveAsync();
        }

        public IQueryable<ResultMembershipDto> GetAllMemberships()
        {
            return _repositoryManager.MembershipRepository.GetAllMemberships().Select(resultMembershipDto => new ResultMembershipDto
            {
                Id = resultMembershipDto.Id,
                Name = resultMembershipDto.Name,
                Price = resultMembershipDto.Price,
            });
        }

        public async Task UpdateMembershipAsync(UpdateMembershipDto updateMembershipDto)
        {
            var membership = _mapper.Map<Entities.Models.Membership>(updateMembershipDto);
            _repositoryManager.MembershipRepository.UpdateMembership(membership);
            await _repositoryManager.SaveAsync();
        }
    }
}
