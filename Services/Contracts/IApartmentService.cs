using Entities.Dtos.ApartmentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IApartmentService
    {
        Task CreateApartmentAsync(CreateApartmentDto createApartmentDto);
        Task UpdateApartmentAsync(UpdateApartmentDto updateApartmentDto);
        Task DeleteApartmentAsync(int id);
        IQueryable<ApartmentDto> GetAllApartments();
    }
}
