using System;

namespace PostSharpBug.Messaging.Events
{
    public class UserLoggedOnEvent : IMessage
    {
        public DateTime TimeStamp { get; set; }

        public Guid UserId { get; set; }
    }
}