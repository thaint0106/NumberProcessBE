using MediatR;
using Microsoft.Extensions.DependencyInjection;
using NumberProcessApplication.Commamds;
using NumberProcessApplication.Conigurations;
using NumberProcessApplication.EventHandlers;
using NumberProcessApplication.Interfaces;
using NumberProcessApplication.Services;
using System.Collections.Generic;

namespace NumberProcessApplication
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            services.AddScoped<IRequestHandler<NumberProcessingCommand, List<int>>, NumberProcessingCommandHandler>();
            services.AddScoped<INotificationHandler<Notification>, DomainNotificationHandler>();
            services.AddScoped<INumberProcessService, NumberProcessService>();
        }
    }
}
