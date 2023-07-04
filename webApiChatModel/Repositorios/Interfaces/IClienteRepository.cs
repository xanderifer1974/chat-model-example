using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.Interfaces
{
    public interface IClienteRepository
    {
        Task<List<ClienteModel>> ListarTodosClientes();
        Task<ClienteModel> ObterClientePorCPF(long cpf);
    }
}
