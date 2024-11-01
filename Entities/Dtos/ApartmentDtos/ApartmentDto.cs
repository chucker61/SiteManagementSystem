using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.ApartmentDtos
{
    public record ApartmentDto
    {
        public string Name { get; init; }
        public int SiteId { get; init; }
    }
}
