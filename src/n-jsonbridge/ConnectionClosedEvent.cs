using N.Package.Events;

namespace N.Package.JsonBridge
{
    public class ConnectionClosedEvent : IEvent
    {
        public IEventApi Api { get; set; }
    }
}