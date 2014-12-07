using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MV.WebApi.JsonObject;
using System.Threading.Tasks;

namespace MV.WebApi.Interfaces
{
    public interface IMVWebApiClient
    {
        Task<List<Sim>> GetSimsAsync();
        Sim_Balance GetSimBalance(string simId);
        List<Usage> GetSimUsage(string simId);

    }
}
