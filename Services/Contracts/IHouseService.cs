using Entities.Dtos.HouseDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IHouseService
    {
        Task CreateHouseAsync(CreateHouseDto createHouseDto);
        Task UpdateHouseAsync(UpdateHouseDto updateHouseDto);
        Task DeleteHouseAsync(int houseId);
        IQueryable<ResultHouseDto> GetAllHouses();
    }
}
