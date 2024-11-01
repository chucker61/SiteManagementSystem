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
    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.HasData(
                new Site
                {
                    Id = 1,
                    Name = "Site 1",
                },
                new Site
                {
                    Id = 2,
                    Name = "Site 2",
                },
                new Site
                {
                    Id = 3,
                    Name = "Site 3",
                }
                );
        }
    }
}
