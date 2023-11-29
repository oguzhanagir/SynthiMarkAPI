﻿using Microsoft.AspNetCore.Builder;
using SynthiMarkAPI.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SynthiMarkAPI.SignalR
{
    public static class HubRegistration
    {
        public static void MapHubs(this WebApplication webApplication)
        {
            webApplication.MapHub<AdvertisingHub>("/advertising-hub");
        }
    }
}
