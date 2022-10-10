using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Teste_Vaga_Investimentos.Domain;

namespace Teste_Vaga_Investimentos.Infra.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> ObterClientePorId(Guid id);
        Task<List<Cliente>> ListarClientes();
    }
}