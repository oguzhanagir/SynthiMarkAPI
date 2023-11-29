using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SynthiMarkAPI.Application.Abstractions.Hubs;
using SynthiMarkAPI.SignalR.Hubs;

namespace SynthiMarkAPI.SignalR.HubServices
{
    public class AdvertisingHubService : IAdvertisingHubService
    {
        readonly IHubContext<AdvertisingHub> _hubContext;

        public AdvertisingHubService(IHubContext<AdvertisingHub> hubContext)
        {
            _hubContext = hubContext;
        }
         
        public async Task AdvertisingAddedMessageAsync(string message)
        {
            await _hubContext.Clients.All.SendAsync(ReceiverFunctionNames.AdvertisingAddedMessage, message);
        }



    }
}
