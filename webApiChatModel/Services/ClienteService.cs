using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Services.Interface;

namespace webApiChatModel.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio)
        {
           _clienteRepositorio = clienteRepositorio;
        }

        public async Task<List<ClienteModel>> ListarTodosClientes()
        {
           return await _clienteRepositorio.ListarTodosClientes();
        }

        public async Task<ClienteModel> ObterClientePorCPF(long cpf)
        {  
            return await _clienteRepositorio.ObterClientePorCPF(cpf);
        }

        public bool VerificaCpfCadastrado(long cpf)
        {
            return _clienteRepositorio.VerificaCpfCadastrado(cpf);
        }
    }
}
