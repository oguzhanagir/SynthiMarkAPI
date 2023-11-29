using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.Application.Abstractions.Hubs
{
    public interface IAdvertisingHubService
    {
        Task AdvertisingAddedMessageAsync(string message);
    }
}
