using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Models.EventModels
{
    public class EventType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public EventType()
        {
            Id = Guid.NewGuid();
        }
    }
}
