using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.SiteDtos
{
    public record ResultSiteDto : SiteDto
    {
        public int Id { get; init; }
        public List<Apartment> Apartments { get; init; } = new();
    }
}
