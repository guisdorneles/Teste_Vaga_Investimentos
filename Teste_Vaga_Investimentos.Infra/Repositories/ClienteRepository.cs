using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste_Vaga_Investimentos.Domain;
using Teste_Vaga_Investimentos.Infra.Interfaces;

namespace Teste_Vaga_Investimentos.Infra.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private List<Cliente> _listaClientes = new List<Cliente>();
        public ClienteRepository()
        {
            _listaClientes.Add(new Cliente()
            {
                Id = new Guid("a607f7f3-fcbb-4585-aaf4-a2d37189d2a3"),
                Nome = "Guilherme",
                Idade = 30
            });
            _listaClientes.Add(new Cliente()
            {
                Id = new Guid("eca3f489-4747-47e4-8b6f-cf66f5d6165a"),
                Nome = "João",
                Idade = 45
            });
            _listaClientes.Add(new Cliente()
            {
                Id = new Guid("1f4bcf50-c497-41d2-8cc4-e5a4a79f7b08"),
                Nome = "Felipe",
                Idade = 31
            });
        }

        public async Task<List<Cliente>> ListarClientes()
        {
            await Task.Delay(100);
            return _listaClientes;
        }

        public async Task<Cliente> ObterClientePorId(Guid id)
        {
            await Task.Delay(100);
            return _listaClientes.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }
    }
}