using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class HouseRepository : RepositoryBase<House>, IHouseRepository
    {
        public HouseRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateHouse(House house)
        {
            Create(house);
        }

        public void DeleteHouse(House house)
        {
            Delete(house);
        }

        public IQueryable<House> GetAllHouses()
        {
            return FindAll();
        }

        public Task<House> GetHouseByIdAsync(int? houseId)
        {
            return FindByCondition(s => s.Id.Equals(houseId)).FirstOrDefaultAsync();
        }

        public Task<House> GetHouseByUserIdAsync(string userId)
        {
            return FindByCondition(s => s.AppUserId.Equals(userId)).FirstOrDefaultAsync();
        }

        public void UpdateHouse(House house)
        {
            Update(house);
        }
    }
}
