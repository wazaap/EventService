using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Models.EventModels
{
    public class Event
    {
        public Guid Id { get; set; }
        public EventType Type { get; set; }

        public Event()
        {
            Id = Guid.NewGuid();
        }
    }
}
