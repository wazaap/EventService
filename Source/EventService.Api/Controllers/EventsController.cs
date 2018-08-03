using System;
using System.Collections.Generic;
using System.Linq;
using EventService.Api.Models;
using EventService.Data;
using EventService.Entities.EventEntities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsRepository _eventsRepository;

        public EventsController(IEventsRepository eventsRepository)
        {
            _eventsRepository = eventsRepository;
        }

        [HttpGet("item/status/{id}")]
        public Event GetItemStatus(Guid id)
        {
            return _eventsRepository.GetAllByItem(id).OrderBy(e => e.Triggered).First();
        }

        // GET api/values/5
        [HttpGet("/trigger/{id}")]
        public IEnumerable<Event> GetByTrigger(string id)
        {
            return _eventsRepository.GetAllByTriggerdBy(id);
        }

        // GET api/events/item/5
        [HttpGet("item/{id}")]
        public IEnumerable<Event> GetByItem(Guid id)
        {
            return _eventsRepository.GetAllByItem(id);
        }

        [HttpGet("application/{id}")]
        public IEnumerable<Event> GetByApplication(Guid id)
        {
            return _eventsRepository.GetAllByApplication(id);
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] CreateEventModel model)
        {
            try
            {
                var eventEntity = new Event(model.ApplicationId, model.ItemId, model.TriggeredBy, model.Type);
                _eventsRepository.Add(eventEntity);
                return Ok();
            } catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
