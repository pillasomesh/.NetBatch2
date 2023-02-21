using ConfigDemoAPI.Core.Contracts.Repositories;
using ConfigDemoAPI.Core.Contracts.Services;
using ConfigDemoAPI.Infrastructure.Context;
using ConfigDemoAPI.Infrastructure.Repositories;
using ConfigDemoAPI.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using TestAPI.Core.ConfigModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
IConfiguration configuration = builder.Configuration;
builder.Services.AddControllers();
//To start using the options pattern for reading GlobalSettings, we need to configure it with DI first
builder.Services.Configure<GlobalConfig>(builder.Configuration.GetSection("GlobalSettings"));
//Register an arbitrary JSON configuration file
builder.Host.ConfigureAppConfiguration(config =>
{
    config.AddJsonFile("config.json");
});
//Register dbcontext file as service in the IServiceCollection and configure it to connect to Sql server database.
builder.Services.AddSqlServer<ClientPortalDbContext>(configuration.GetConnectionString("ClientPortalDbContext"));
builder.Services.AddTransient<IClientPortalRepository, ClientPortalRepository>();
builder.Services.AddTransient<IClientPortalService, ClientPortalService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
