using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
    public interface ISiteRepository : IRepositoryBase<Site>
    {
        void CreateOneSite(Site site);
        void UpdateOneSite(Site site);
        void DeleteOneSite(Site site);
        IQueryable<Site> GetAllSites();
        Task<Site> GetSiteByIdAsync(int siteId);
    }
}
