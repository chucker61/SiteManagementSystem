using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IApartmentRepository : IRepositoryBase<Apartment>
    {
        void CreateApartment(Apartment apartment);
        void UpdateApartment(Apartment apartment);
        void DeleteApartment(Apartment apartment);
        IQueryable<Apartment> GetAllApartments();
        Task<Apartment> GetApartmentByIdAsync(int apartmentId);
    }
}
