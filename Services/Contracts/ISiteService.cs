using Entities.Dtos.SiteDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface ISiteService
    {
        Task CreateSiteAsync(CreateSiteDto createSiteDto);
        Task UpdateSiteAsync(UpdateSiteDto updateSiteDto);
        Task DeleteSiteAsync(int siteId);
        IQueryable<ResultSiteDto> GetAllSites();
        Task<GetByIdSiteDto> GetOneSiteOfSiteManager(string userName);
    }
}
