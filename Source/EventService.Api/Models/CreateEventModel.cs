using EventService.Entities.EventEntities;
using System;

namespace EventService.Api.Models
{
    public class CreateEventModel
    {
        public Guid ApplicationId { get; set; }
        public Guid ItemId{ get; set; }
        public string TriggerdBy { get; set; }
        public EventType Type { get; set; }
    }
}
