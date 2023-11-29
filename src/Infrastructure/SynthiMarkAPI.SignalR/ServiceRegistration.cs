using Microsoft.Extensions.DependencyInjection;
using SynthiMarkAPI.Application.Abstractions.Hubs;
using SynthiMarkAPI.SignalR.HubServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.SignalR
{
    public static class ServiceRegistration
    {
        public static void AddSignalRServices(this IServiceCollection collection)
        {
            collection.AddTransient<IAdvertisingHubService, AdvertisingHubService>();
            collection.AddSignalR();
        }
    }
}
