using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using TestAPI.Core.ConfigModel;

namespace TestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionsDemoController : ControllerBase
    {
        private readonly GlobalConfig globalConfigSettings;
        public OptionsDemoController(IOptions<GlobalConfig> _config)
        { globalConfigSettings=_config.Value; }

        [HttpGet("globalsettings")]
        public GlobalConfig Get() => globalConfigSettings;

    }
}
