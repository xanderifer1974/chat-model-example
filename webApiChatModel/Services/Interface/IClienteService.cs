using webApiChatModel.Models;

namespace webApiChatModel.Services.Interface
{
    public interface IClienteService
    {
        Task<List<ClienteModel>> ListarTodosClientes();
        Task<ClienteModel> ObterClientePorCPF(long cpf);
    }
}
