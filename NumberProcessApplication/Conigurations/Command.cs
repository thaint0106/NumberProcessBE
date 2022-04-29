using FluentValidation.Results;
using System;

namespace NumberProcessApplication.CommandHandlers
{
    public abstract class Command
    {
        public DateTime Timestamp { get; private set; }
        public ValidationResult ValidationResult { get; set; }
        public string MessageType { get; set; }

        protected Command()
        {
            MessageType = GetType().Name;
        }
        public abstract bool IsValid();
    }


}
