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
    public class ApartmanRepository : RepositoryBase<Apartment>, IApartmentRepository
    {
        public ApartmanRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateApartment(Apartment apartment)
        {
            Create(apartment);
        }

        public void DeleteApartment(Apartment apartment)
        {
            Delete(apartment);
        }

        public IQueryable<Apartment> GetAllApartments()
        {
            return FindAll();
        }

        public Task<Apartment> GetApartmentByIdAsync(int apartmentId)
        {
            return FindByCondition(s => s.Id.Equals(apartmentId)).FirstOrDefaultAsync();
        }

        public void UpdateApartment(Apartment apartment)
        {
            Update(apartment);
        }
    }
}
