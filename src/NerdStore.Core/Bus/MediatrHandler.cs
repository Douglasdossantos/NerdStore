using MediatR;
using NerdStore.Core.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Core.Bus
{
    public class MediatrHandler : IMediatorHandler
    {
        private readonly IMediator _mediatr;

        public MediatrHandler(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        public Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            throw new NotImplementedException();
        }

        public async Task<bool> EnviarCommando<T>(T comando) where T : Command
        {
            return await _mediatr.Send(comando);
        }

        public Task PublicarEvento<T>(T evento) where T : Event
        {
            throw new NotImplementedException();
        }

        public async Task PublicarEventos<T>(T evento) where T : Event
        {
            await _mediatr.Publish(evento);
        }

        //public Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification
        //{
        //    throw new NotImplementedException();
        //}
    }
}
