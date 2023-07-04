using Microsoft.AspNetCore.Mvc;
using webApiChatModel.Models;
using webApiChatModel.Services.Interface;

namespace webApiChatModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ClienteModel>>> ListarTodosClientes()
        {
            List<ClienteModel> listCliente = await  _clienteService.ListarTodosClientes();

            return Ok(listCliente);
        }

        [HttpGet("pesquisarPorCpf/{cpf}")]
        public async Task<ActionResult<ClienteModel>> PesquisarClientePorC(long cpf)
        {
            bool verificaCPFCadastrado = _clienteService.VerificaCpfCadastrado(cpf);

            if (verificaCPFCadastrado)
            {
                ClienteModel cliente = await _clienteService.ObterClientePorCPF(cpf);
                return Ok(cliente);
            }
            else
            {
                return NotFound("Cliente não encontrado.");
            }          
           
        }
    }
}
