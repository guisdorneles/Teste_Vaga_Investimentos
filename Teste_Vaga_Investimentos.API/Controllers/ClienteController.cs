using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Teste_Vaga_Investimentos.API.Filters;
using Teste_Vaga_Investimentos.Service.Interfaces;

namespace Teste_Vaga_Investimentos.Application.Controllers
{
    
    [ApiController]
    [ValidateModelAttribute]
    [Route("v1/cliente")]

    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;
        private readonly ILogger<ClienteController> _logger;
        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet()]
        public async Task<IActionResult> ObterClientePorId(Guid id)
        {
            if (Guid.Empty == (Guid)id)
            {
                return UnprocessableEntity("Informe um id válido");
            }

            return Ok(await _clienteService.ObterClientePorId(id));

        }

        [HttpGet("listar")]
        public async Task<IActionResult> ListarClientes()
        {
            return Ok(await _clienteService.ListarClientes());
        }
    }
}