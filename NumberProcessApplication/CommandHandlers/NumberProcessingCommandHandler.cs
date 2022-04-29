using MediatR;
using NumberProcessApplication.Commamds;
using NumberProcessApplication.Conigurations;
using NumberProcessApplication.Helpers;
using NumberProcessApplication.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NumberProcessApplication.EventHandlers
{
    public class NumberProcessingCommandHandler : CommandHandler, IRequestHandler<NumberProcessingCommand, List<int>>
    {
        private readonly INumberProcessService numberProcessService;

        public NumberProcessingCommandHandler(IMediator mediator, INumberProcessService numberProcessService) : base(mediator)
        {
            this.numberProcessService = numberProcessService;
        }

        //Handle command
        public async Task<List<int>> Handle(NumberProcessingCommand request, CancellationToken cancellationToken)
        {
            //validation
            if (!request.IsValid())
            {
                NotifyValidationErrors(request);
                return await Task.FromResult(new List<int>());
            }
            var numbers = Helper.ConvertStringToList(request.Input);
            //check another validation
            if (numbers.Count < request.AmountItem)
            {
                await _mediator.Publish(new Notification(request.MessageType, "At least 10 item in array"));
            }
            else
                numberProcessService.MoveMaxItemsToCenter(numbers, request.AmountItem);
            return await Task.FromResult(numbers);
        }
    }
}
