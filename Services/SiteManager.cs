using AutoMapper;
using Entities.Dtos.SiteDtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SiteManager : ISiteService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public SiteManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task CreateSiteAsync(CreateSiteDto createSiteDto)
        {
            var site = _mapper.Map<Entities.Models.Site>(createSiteDto);
            _repositoryManager.SiteRepository.CreateOneSite(site);
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteSiteAsync(int siteId)
        {
            var site = await _repositoryManager.SiteRepository.GetSiteByIdAsync(siteId);
            _repositoryManager.SiteRepository.DeleteOneSite(site);
            await _repositoryManager.SaveAsync();
        }

        public IQueryable<ResultSiteDto> GetAllSites()
        {
            return _repositoryManager.SiteRepository.GetAllSites().Select(resultSiteDto => new ResultSiteDto
            {
                Id = resultSiteDto.Id,
                Name = resultSiteDto.Name,
                Apartments = resultSiteDto.Apartments.ToList()
            });
        }

        public async Task<GetByIdSiteDto> GetOneSiteOfSiteManager(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);
            if (user == null)
                throw new Exception("User not found");

            var house = await _repositoryManager.HouseRepository.GetHouseByUserIdAsync(user.Id);
            var apartment = await _repositoryManager.ApartmentRepository.GetApartmentByIdAsync(house.ApartmentId);
            var site = await _repositoryManager.SiteRepository.GetSiteByIdAsync(apartment.SiteId);
            if (site == null)
                throw new Exception("Site not found");

            return _mapper.Map<GetByIdSiteDto>(site);

        }

        public async Task UpdateSiteAsync(UpdateSiteDto updateSiteDto)
        {
            var site = _mapper.Map<Entities.Models.Site>(updateSiteDto);
            _repositoryManager.SiteRepository.UpdateOneSite(site);
            await _repositoryManager.SaveAsync();
        }
    }
}
