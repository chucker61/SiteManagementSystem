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
    public class MembershipRepository : RepositoryBase<Membership>, IMembershipRepository
    {
        public MembershipRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateMembership(Membership membership)
        {
            Create(membership);
        }

        public void DeleteMembership(Membership membership)
        {
            Delete(membership);
        }

        public IQueryable<Membership> GetAllMemberships()
        {
            return FindAll();
        }

        public Task<Membership> GetMembershipByIdAsync(int membershipId)
        {
            return FindByCondition(s => s.Id.Equals(membershipId)).FirstOrDefaultAsync();
        }

        public void UpdateMembership(Membership membership)
        {
            Update(membership);
        }
    }
}
