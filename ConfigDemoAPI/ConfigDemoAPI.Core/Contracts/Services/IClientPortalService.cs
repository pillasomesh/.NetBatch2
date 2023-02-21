using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Core.Entities;

namespace ConfigDemoAPI.Core.Contracts.Services
{
    public interface IClientPortalService
    {
        Task<Client?> GetClientByAccountIdAsync(int accountId);
    }
}
