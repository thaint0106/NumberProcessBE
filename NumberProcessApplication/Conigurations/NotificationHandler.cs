using MediatR;
using NumberProcessApplication.CommandHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace NumberProcessApplication.Conigurations
{
    public class DomainNotificationHandler : INotificationHandler<Notification>
    {
        private List<Notification> _notifications;

        public DomainNotificationHandler()
        {
            _notifications = new List<Notification>();
        }

        public Task Handle(Notification message, CancellationToken cancellationToken)
        {
            _notifications.Add(message);

            return Task.CompletedTask;
        }

        public virtual List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public virtual bool HasNotifications()
        {
            return GetNotifications().Any();
        }

        public void Dispose()
        {
            _notifications = new List<Notification>();
        }
    }
}
