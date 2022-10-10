using Microsoft.Extensions.DependencyInjection;
using Teste_Vaga_Investimentos.Service.Interfaces;
using Teste_Vaga_Investimentos.Service.Services;

namespace Teste_Vaga_Investimentos.Application.Configurations
{

    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IClienteService, ClienteService>();
            
            return services;
        }
    }
}