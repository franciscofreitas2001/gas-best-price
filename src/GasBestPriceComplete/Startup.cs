﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Lime.Protocol.Server;
using Take.Blip.Client;
using System.Reflection;
using Lime.Protocol.Serialization;

namespace GasBestPrice
{
    /// <summary>
    /// Defines a type that is called once during the application initialization.
    /// </summary>
    public class Startup : IStartable
    {
        private readonly ISender _sender;
        private readonly Settings _settings;

        public Startup(ISender sender, Settings settings)
        {
            _sender = sender;
            _settings = settings;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            TypeUtil.RegisterDocuments(typeof(Startup).GetTypeInfo().Assembly);
            return Task.CompletedTask;
        }
    }
}
