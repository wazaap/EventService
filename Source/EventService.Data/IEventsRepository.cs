using System;
using System.Collections.Generic;
using EventService.Entities.EventEntities;

namespace EventService.Data
{
    public interface IEventsRepository
    {
        void Add(Event e);
        IEnumerable<Event> GetAllByApplication(Guid applicationId);
        IEnumerable<Event> GetAllByItem(Guid itemId);
        IEnumerable<Event> GetAllByTriggerdBy(Guid triggerById);
    }
}