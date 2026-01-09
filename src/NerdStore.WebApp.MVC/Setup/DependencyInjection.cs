using MediatR;
using NerdStore.Catalago.Application.Services;
using NerdStore.Catalago.Data;
using NerdStore.Catalago.Data.Repository;
using NerdStore.Catalago.Domain;
using NerdStore.Catalago.Domain.Events;
using NerdStore.Core.Bus;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Data;
using NerdStore.Vendas.Data.Repository;
using NerdStore.Vendas.Domain;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IMediatorHandler, MediatrHandler>();
            //catalago
            services.AddScoped<IProdutoRepository, ProdutoRepository> ();
            services.AddScoped<IProdutoAppService, ProdutoAppService> ();
            services.AddScoped<IEstoqueService, EstoqueService> ();
            services.AddScoped<CatalagoContext>();
            //produto
            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();

            //vendas
            services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<VendasContext>();


        }
    }
}
