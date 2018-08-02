using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventService.Models.EventModels
{
    public class Event
    {
        public Guid Id { get; set; }
        public EventType Type { get; set; }
    }
}
