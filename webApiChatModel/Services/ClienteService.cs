using webApiChatModel.Models;
using webApiChatModel.Services.Interface;

namespace webApiChatModel.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteService _clienteService;

        public ClienteService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public async Task<List<ClienteModel>> ListarTodosClientes()
        {
           return await _clienteService.ListarTodosClientes();
        }

        public async Task<ClienteModel> ObterClientePorCPF(long cpf)
        {
            return await _clienteService.ObterClientePorCPF(cpf);
        }
    }
}
