using MediatR;
using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Comunication.Mediator
{
    public class MediatrHandler : IMediatorHandler
    {
        private readonly IMediator _mediatr;

        public MediatrHandler(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public async Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            return await _mediatr.Send(comando);
        }

        public  async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediatr.Publish(evento);
        }



        public async Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification
        {
            await _mediatr.Publish(notificacao);
        }
    }
}
