using MediatR;
using NumberProcessApplication.CommandHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace NumberProcessApplication.Conigurations
{
    public class CommandHandler
    {
        protected readonly IMediator _mediator;

        public CommandHandler(IMediator bus)
        {

            _mediator = bus;
        }

        protected void NotifyValidationErrors(Command message)
        {
            if (message?.ValidationResult?.Errors == null) return;
            foreach (var error in message.ValidationResult.Errors)
            {
                _mediator.Publish(new Notification(message.MessageType, error.ErrorMessage));
            }
        }
    }

}
