using MediatR;
using System;

namespace NumberProcessApplication.Conigurations
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; set; }
        public Guid AggregateId { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
