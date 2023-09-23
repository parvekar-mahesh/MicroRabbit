﻿using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T> (T command) where T : Command;    
        void Publish<T> (T @event);
        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
