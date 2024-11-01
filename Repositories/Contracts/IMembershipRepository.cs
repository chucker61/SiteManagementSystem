using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface IMembershipRepository : IRepositoryBase<Membership>
    {
        void CreateMembership(Membership membership);
        void UpdateMembership(Membership membership);
        void DeleteMembership(Membership membership);
        Task<Membership> GetMembershipByIdAsync(int id);
        IQueryable<Membership> GetAllMemberships();
    }
}
