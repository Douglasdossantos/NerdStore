using NerdStore.Core.Comunication.Mediator;
using NerdStore.Core.DomainObjects;
using NerdStore.Core.Messages.CommonMessages.DomainEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Vendas.Data
{
    public  static class MediatorExtension
    {
        public static async Task PublicarEvento(this IMediatorHandler mediator, VendasContext ctx)
        {
            var domainEntities = ctx.ChangeTracker
                .Entries<Entity>()
                .Where(x => x.Entity.Notificacoes != null && x.Entity.Notificacoes.Any());

            var domainEvents = domainEntities
                .SelectMany( x => x.Entity.Notificacoes)
                .ToList();

            domainEntities.ToList()
                .ForEach(Entity => Entity.Entity.LimparEventos());

            var task = domainEvents
                .Select(async (domainEvent) =>
                {
                    await mediator.PublicarEvento(domainEvent);
                });

            await Task.WhenAll(task);
        }
    }
}