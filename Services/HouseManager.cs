using AutoMapper;
using Entities.Dtos.HouseDtos;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HouseManager : IHouseService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public HouseManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task CreateHouseAsync(CreateHouseDto createHouseDto)
        {
            var house = _mapper.Map<Entities.Models.House>(createHouseDto);
            _repositoryManager.HouseRepository.CreateHouse(house);
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteHouseAsync(int houseId)
        {
            var house = await _repositoryManager.HouseRepository.GetHouseByIdAsync(houseId);
            _repositoryManager.HouseRepository.DeleteHouse(house);
            await _repositoryManager.SaveAsync();
        }

        public IQueryable<ResultHouseDto> GetAllHouses()
        {
            return _repositoryManager.HouseRepository.GetAllHouses().Select(resultHouseDto => new ResultHouseDto
            {
                Id = resultHouseDto.Id,
                Num = resultHouseDto.Num,
            });
        }

        public async Task UpdateHouseAsync(UpdateHouseDto updateHouseDto)
        {
            var house = _mapper.Map<Entities.Models.House>(updateHouseDto);
            _repositoryManager.HouseRepository.UpdateHouse(house);
            await _repositoryManager.SaveAsync();
        }
    }
}
