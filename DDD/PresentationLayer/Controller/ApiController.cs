using System.Collections.Generic;
using System.Linq;
using DomainLayer.Core.Notification;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controller
{
    public class ApiController : ControllerBase
    {
        private readonly DomainNotificationHandler _notificationHandler;

        public ApiController(INotificationHandler<DomainNotification> notificationHandler)
        {
            _notificationHandler = (DomainNotificationHandler)notificationHandler;
        }

        protected IEnumerable<string> Errors => _notificationHandler.Notifications.Select(x => x.Value);
    }
}