using SiteManagementSystem.Extensions;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureService()
    .ConfigurePipeline();
app.Run();

