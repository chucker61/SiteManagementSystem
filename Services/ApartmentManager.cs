using AutoMapper;
using Entities.Dtos.ApartmentDtos;
using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ApartmentManager : IApartmentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ApartmentManager(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task CreateApartmentAsync(CreateApartmentDto createApartmentDto)
        {
            var apartment = _mapper.Map<Apartment>(createApartmentDto);
            _repositoryManager.ApartmentRepository.CreateApartment(apartment);
            await _repositoryManager.SaveAsync();
        }

        public async Task DeleteApartmentAsync(int id)
        {
            var apartment = await _repositoryManager.ApartmentRepository.GetApartmentByIdAsync(id);
            _repositoryManager.ApartmentRepository.Delete(apartment);
            await _repositoryManager.SaveAsync();
        }

        public IQueryable<ApartmentDto> GetAllApartments()
        {
            return _repositoryManager.ApartmentRepository.GetAllApartments().Select(resultApartmentDto => new ResultApartmentDto
            {
                Id = resultApartmentDto.Id,
                Name = resultApartmentDto.Name,
                SiteId = resultApartmentDto.SiteId,
                Houses = resultApartmentDto.Houses.ToList()
            });
        }

        public async Task UpdateApartmentAsync(UpdateApartmentDto updateApartmentDto)
        {
            var apartment = _mapper.Map<Apartment>(updateApartmentDto);
            _repositoryManager.ApartmentRepository.UpdateApartment(apartment);
            await _repositoryManager.SaveAsync();
        }
    }
}
