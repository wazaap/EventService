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
        public Guid TriggeredBy { get; }
        public EventType Type { get; set; }
        public DateTime Triggered { get; set; }

        public Event()
        {
            Id = Guid.NewGuid();
        }

        public Event(Guid applicationId, Guid itemId, string triggeredBy, EventType eventType)
        {
            var triggeredId = StringToGUID(triggeredBy);
            Id = Guid.NewGuid();
            ApplicationId = applicationId;
            Type = eventType;
            Triggered = DateTime.UtcNow;
            TriggeredBy = triggeredId;
        }

        private Guid StringToGUID(string value)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(value));
            return new Guid(data);
        }
    }
}
