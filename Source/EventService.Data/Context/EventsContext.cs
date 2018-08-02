using EventService.Models.EventModels;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventService.Data.Context
{
    public class EventsContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<EventType> EventTypes { get; set; }

        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }

    }
}
