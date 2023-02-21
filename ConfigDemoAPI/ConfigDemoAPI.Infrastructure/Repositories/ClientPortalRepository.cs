using ConfigDemoAPI.Core.Contracts.Repositories;
using ConfigDemoAPI.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using TestAPI.Core.Entities;

namespace ConfigDemoAPI.Infrastructure.Repositories
{
    public class ClientPortalRepository : IClientPortalRepository
    {
        private readonly ClientPortalDbContext _dbContext;

        public ClientPortalRepository(ClientPortalDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Client?> GetClientByAccountIdAsync(int accountId)
        {
            return await _dbContext.Clients.AsQueryable().FirstOrDefaultAsync(d => d.AccountId == accountId);
        }
    }
}
