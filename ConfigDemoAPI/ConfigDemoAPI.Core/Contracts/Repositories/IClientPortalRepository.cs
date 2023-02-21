using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Core.Entities;

namespace ConfigDemoAPI.Core.Contracts.Repositories
{
    public interface IClientPortalRepository
    {
        Task<Client?> GetClientByAccountIdAsync(int accountId);
    }
}
