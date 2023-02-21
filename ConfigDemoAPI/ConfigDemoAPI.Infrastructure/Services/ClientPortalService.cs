using ConfigDemoAPI.Core.Contracts.Repositories;
using ConfigDemoAPI.Core.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Core.Entities;

namespace ConfigDemoAPI.Infrastructure.Services
{
    public class ClientPortalService : IClientPortalService
    {
        private readonly IClientPortalRepository _clientPortalRepository;

        public ClientPortalService(IClientPortalRepository clientPortalRepository)
        {
            _clientPortalRepository = clientPortalRepository;
        }

        public async Task<Client?> GetClientByAccountIdAsync(int accountId)
        {
            var client = await _clientPortalRepository.GetClientByAccountIdAsync(accountId);
            return client;
        }
    }
}
