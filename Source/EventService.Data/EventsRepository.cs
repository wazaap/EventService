using EventService.Data.Context;
using EventService.Entities.EventEntities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventService.Data
{
    public class EventsRepository : IEventsRepository
    {
        private readonly EventsContext _eventsContext;

        public EventsRepository(EventsContext eventsContext)
        {
            _eventsContext = eventsContext;
        }

        public void Add(Event e)
        {
            _eventsContext.Events.Add(e);
            _eventsContext.SaveChanges();
        }

        public IEnumerable<Event> GetAllByApplication(Guid applicationId)
        {
            if (!_eventsContext.Events.Any(e => e.ApplicationId == applicationId))
            {
                return Enumerable.Empty<Event>();
            }
            return _eventsContext.Events.Where(e => e.ApplicationId == applicationId);
        }

        public IEnumerable<Event> GetAllByItem(Guid itemId)
        {
            if (!_eventsContext.Events.Any(e => e.ItemId == itemId))
            {
                return Enumerable.Empty<Event>();
            }
            return _eventsContext.Events.Where(e => e.ItemId == itemId);
        }

        public IEnumerable<Event> GetAllByTriggerdBy(Guid triggerById)
        {
            if (!_eventsContext.Events.Any(e => e.TriggeredBy == triggerById))
            {
                return Enumerable.Empty<Event>();
            }
            return _eventsContext.Events.Where(e => e.TriggeredBy == triggerById);
        }
    }
}
