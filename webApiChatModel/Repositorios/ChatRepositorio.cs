using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;

namespace webApiChatModel.Repositorios
{
    public class ChatRepositorio : IChatRepositorio
    {
        
      
        public Task<ChatModel> BuscarConversaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ChatModel> BuscarConversaPorPergunta(string pergunta)
        {
            throw new NotImplementedException();
        }

        public Task<List<ChatModel>> BuscarTodasConversas()
        {
            throw new NotImplementedException();
        }      


    }
}
