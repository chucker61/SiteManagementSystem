using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using NLog;
using Repositories.Contracts;
using Repositories.EFCore;
using Services;
using Services.Contracts;
using System;

namespace SiteManagementSystem.Extensions
{
    public static class HostingExtensions
    {
        public static WebApplication ConfigureService(this WebApplicationBuilder builder)
        {
            LogManager.Setup().LoadConfigurationFromFile("nlog.config");

            builder.Services.ConfigureSqlContext(builder.Configuration);

            builder.Services.AddControllers()
                .AddOData(config =>
                {
                    config.Select()
                    .Filter()
                    .Expand()
                    .OrderBy()
                    .Select()
                    .Count()
                    .SetMaxTop(100);
                });

            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.ConfigureIdentity();
            builder.Services.ConfigureJWT(builder.Configuration);

            builder.Services.RegisterRepositories();
            builder.Services.RegisterServices();
            builder.Services.RegisterActionFilters();

            return builder.Build();
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            var logger = app.Services.GetRequiredService<ILoggerService>();
            app.ConfigureExceptionHandler(logger);

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            app.ConfigureDefaultAdminUser();
            return app;
        }
    }
}
