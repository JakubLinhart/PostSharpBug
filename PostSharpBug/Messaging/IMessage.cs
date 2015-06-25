using System;

namespace PostSharpBug.Messaging
{
    public interface IMessage
    {
        DateTime TimeStamp { get; set; }
    }
}