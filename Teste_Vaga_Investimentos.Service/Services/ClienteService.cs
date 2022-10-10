using Teste_Vaga_Investimentos.Service.Interfaces;
using Teste_Vaga_Investimentos.Domain;
using System;
using System.Collections.Generic;
using Teste_Vaga_Investimentos.Infra.Interfaces;
using System.Threading.Tasks;

namespace Teste_Vaga_Investimentos.Service.Services
{

    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            return await _clienteRepository.ListarClientes();
        }

        public async Task<Cliente> ObterClientePorId(Guid id)
        {
            return await _clienteRepository.ObterClientePorId(id);
        }
    }
}