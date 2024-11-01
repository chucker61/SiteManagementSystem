using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
    public class MembershipConfiguration : IEntityTypeConfiguration<Membership>
    {
        public void Configure(EntityTypeBuilder<Membership> builder)
        {
            builder.HasData(
                new Membership
                {
                    Id = 1,
                    Name = "Free",
                    Price = 0
                },
                new Membership
                {
                    Id = 2,
                    Name = "Bronz",
                    Price = 50
                },
                new Membership
                {
                    Id = 3,
                    Name = "Silver",
                    Price = 75
                },
                new Membership
                {
                    Id = 4,
                    Name = "Gold",
                    Price = 100
                }
                );
        }
    }
}
