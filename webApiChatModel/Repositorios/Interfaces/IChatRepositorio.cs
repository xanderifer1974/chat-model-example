using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.Interfaces
{
    public interface IChatRepositorio
    {
        Task<List<ChatModel>> BuscarTodasConversas();
        Task<ChatModel> BuscarConversaPorId(int id);
        Task<ChatModel> BuscarConversaPorPergunta(string pergunta);

    }
}
