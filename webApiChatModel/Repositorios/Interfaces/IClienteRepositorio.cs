using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.Interfaces
{
    public interface IClienteRepositorio
    {
        Task<List<ClienteModel>> ListarTodosClientes();
        Task<ClienteModel> ObterClientePorCPF(long cpf);
        bool VerificaCpfCadastrado(long cpf);
    }
}
