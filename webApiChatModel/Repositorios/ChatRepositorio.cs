using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Repositorios.MockBD;

namespace webApiChatModel.Repositorios
{
    public class ChatRepositorio : IChatRepositorio
    {
        private readonly List<ChatModel> _chatDB = ChatBDMock.getChatList();

        

        public async Task <List<ChatModel>> BuscarTodasConversas()
        {
            return  _chatDB.ToList();
        }

        public async Task<ChatModel> BuscarConversaPorId(int id)
        {
           return _chatDB.FirstOrDefault(x => x.IdChat == id);      
        }

        public async Task<ChatModel> BuscarConversaPorPergunta(string pergunta)
        {
            return _chatDB.FirstOrDefault(x => x.Pergunta == pergunta);
        }

       
    }
}
