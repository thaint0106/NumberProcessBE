using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumberProcessApplication.Commamds;
using NumberProcessApplication.Conigurations;
using NumberProcessing.Controller;

namespace NumberProcessing.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NumberProcessController : ApiController
    {


        private readonly ILogger<NumberProcessController> _logger;

        public NumberProcessController(ILogger<NumberProcessController> logger, IMediator mediator, INotificationHandler<Notification> notifications) : base(notifications, mediator)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult HealthCheck()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> NumberProcessing(NumberProcessingCommand model)
        {
            var result = await _mediator.Send(model);
            return Response(result);
        }

    }
}
