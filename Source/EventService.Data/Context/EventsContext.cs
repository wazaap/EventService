using EventService.Entities.EventEntities;
using Microsoft.EntityFrameworkCore;

namespace EventService.Data.Context
{
    public class EventsContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }

    }
}
