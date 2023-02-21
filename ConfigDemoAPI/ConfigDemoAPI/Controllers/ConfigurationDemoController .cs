using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using TestAPI.Core.ConfigModel;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigurationDemoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ConfigurationDemoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        /// <summary>
        /// Read connection string values from IConfiguration by using GetValue and GetConnectionString methods
        /// </summary>
        /// <returns></returns>
        [HttpGet("connectionstrings")]
        public string GetConnectionStringsFromAppsettingConfig()
        {
            var connectionString1 = _configuration.GetValue<string>("ConnectionStrings:PrecisionCommunicationDbContext");
            var connectionString = _configuration.GetConnectionString("PrecisionCommunicationDbContext");
            return connectionString;
        }

        /// <summary>
        /// Read config section from config and map to model
        /// </summary>
        /// <returns></returns>
        [HttpGet("globalconfigs")]
        public GlobalConfig GetGlobalConfigs()
        {
            var globalSettings = _configuration.GetSection("GlobalSettings").Get<GlobalConfig>();
            return globalSettings;
        }
        /// <summary>
        /// Read data from config.json file
        /// </summary>
        /// <returns></returns>
        [HttpGet("unconventionalconfigfile")]
        public string GetConnectionStringsFromConfig()
        {
            var connectionString = _configuration.GetValue<string>("LocalConnectionStrings:DefaultConnection");
            return connectionString;
        }
    }
}
