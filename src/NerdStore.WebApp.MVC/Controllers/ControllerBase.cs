using MediatR;
using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Comunication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;

namespace NerdStore.WebApp.MVC.Controllers
{
    public  abstract class ControllerBase : Controller
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatorHandler _mediatorHandler;

        protected Guid ClienteId = Guid.Parse("49285721-0F72-4A72-BC78-7B29B8AE9886");

        protected ControllerBase(INotificationHandler<DomainNotification> notifications,
                                 IMediatorHandler mediatorHandler)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediatorHandler = mediatorHandler;
        }

        protected bool OperacaoValida()
        {
            return !_notifications.TemNotificacoes();
        }

        protected IEnumerable<string> ObterMessagensErro()
        {
            return _notifications.ObterNotificacoes().Select(c => c.Value).ToList();
        }
        protected void NotificarErro(string codigo, string messagem)
        {
            _mediatorHandler.PublicarNotificacao(new DomainNotification(codigo, messagem));
        }
    }
}
