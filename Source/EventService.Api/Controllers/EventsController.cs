using System;
using System.Collections.Generic;
using EventService.Api.Models;
using EventService.Data;
using EventService.Entities.EventEntities;
using Microsoft.AspNetCore.Mvc;

namespace EventService.Api.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        private readonly IEventsRepository _eventsRepository;

        public EventsController(IEventsRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ViewEventModel Get(Guid id)
        {
            return new ViewEventModel();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CreateEventModel model)
        {
            var e = new Event(model.ApplicationId, model.ItemId, model.TriggerdBy,model.Type);
            _eventsRepository.Add(e);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
