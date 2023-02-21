using ConfigDemoAPI.Core.Contracts.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ConfigDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientPortalService _clientPortalService;
        public ClientController( IClientPortalService clientPortalService)
        {
            _clientPortalService = clientPortalService;
        }
        /// <summary>
        /// Get strategy by id
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>
        [HttpGet("client/{accountId}")]
        public async Task<ActionResult> GetClientByAccountId([Required] int accountId)
        {
            var client = await _clientPortalService.GetClientByAccountIdAsync(accountId);
            if (client is not null)
                return Ok(client);
            return NotFound();
        }
    }
}
