using Microsoft.Extensions.DependencyInjection;
using Teste_Vaga_Investimentos.Infra.Interfaces;
using Teste_Vaga_Investimentos.Infra.Repositories;

namespace Teste_Vaga_Investimentos.Application.Configurations
{

    public static class RepositoriesCollectionExtensions
    {
        public static IServiceCollection AddRegisterRepositories(this IServiceCollection servicesRepository)
        {
            servicesRepository.AddTransient<IClienteRepository, ClienteRepository>();
            
            return servicesRepository;
        }
    }
}