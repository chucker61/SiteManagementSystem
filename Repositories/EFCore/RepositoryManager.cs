using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private ISiteRepository _siteRepository;
        private IApartmentRepository _apartmentRepository;
        private IHouseRepository _houseRepository;
        private IMembershipRepository _membershipRepository;

        public RepositoryManager(ApplicationDbContext context, ISiteRepository siteRepository, IApartmentRepository apartmentRepository, IHouseRepository houseRepository, IMembershipRepository membershipRepository)
        {
            _context = context;
            _siteRepository = siteRepository;
            _apartmentRepository = apartmentRepository;
            _houseRepository = houseRepository;
            _membershipRepository = membershipRepository;
        }

        public ISiteRepository SiteRepository => _siteRepository;
        public IApartmentRepository ApartmentRepository => _apartmentRepository;
        public IHouseRepository HouseRepository => _houseRepository;
        public IMembershipRepository MembershipRepository => _membershipRepository;

        public async Task SaveAsync() => await _context.SaveChangesAsync();
    }
}
