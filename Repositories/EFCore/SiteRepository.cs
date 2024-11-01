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
    public class SiteRepository : RepositoryBase<Site>, ISiteRepository
    {
        public SiteRepository(ApplicationDbContext context) : base(context)
        {
        }

        public void CreateOneSite(Site site)
        {
            Create(site);
        }

        public void DeleteOneSite(Site site)
        {
            Delete(site);
        }

        public IQueryable<Site> GetAllSites()
        {
            return FindAll();
        }

        public async Task<Site> GetSiteByIdAsync(int siteId)
        {
            return await FindByCondition(s => s.Id.Equals(siteId)).FirstOrDefaultAsync();
        }

        public void UpdateOneSite(Site site)
        {
            Update(site);
        }
    }
}
