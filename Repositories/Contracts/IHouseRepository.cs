using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IHouseRepository : IRepositoryBase<House>
    {
        void CreateHouse(House house);
        void UpdateHouse(House house);
        void DeleteHouse(House house);
        IQueryable<House> GetAllHouses();
        Task<House> GetHouseByIdAsync(int? houseId);
        Task<House> GetHouseByUserIdAsync(string userId);
    }
}
