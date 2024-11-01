using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.MembeshipDtos
{
    public record MembershipDto
    {
        public string Name { get; init; }
        public decimal Price { get; init; }
    }
}
