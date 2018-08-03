using EventService.Shared;
using System;
using System.Security.Cryptography;
using System.Text;

namespace EventService.Entities.EventEntities
{
    public class Event
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid ItemId { get; set; }
        public Guid TriggeredBy { get; set; }
        public EventType Type { get; set; }
        public DateTime Triggered { get; set; }

        public Event()
        {
            Id = Guid.NewGuid();
        }

        public Event(Guid applicationId, Guid itemId, string triggeredBy, EventType eventType)
        {
            Id = Guid.NewGuid();
            ApplicationId = applicationId;
            Type = eventType;
            Triggered = DateTime.UtcNow;
            TriggeredBy = triggeredBy.ToGuid();
            ItemId = itemId;
        }


    }
}
