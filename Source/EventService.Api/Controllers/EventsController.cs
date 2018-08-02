using System;
using System.Collections.Generic;
using EventService.Api.Models;
using EventService.Entities.EventEntities;
using Microsoft.AspNetCore.Mvc;

namespace EventService.Api.Controllers
{
    [Route("api/[controller]")]
    public class EventsController : Controller
    {
        public EventsController()
        {

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
            //TODO Save event
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
