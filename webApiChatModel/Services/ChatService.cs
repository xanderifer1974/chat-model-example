using webApiChatModel.Models;
using webApiChatModel.Repositorios;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Services.Interface;

namespace webApiChatModel.Services
{
    public class ChatService: IChatService
    {
        private readonly IChatRepositorio _chatRepositorio;

        public ChatService(IChatRepositorio chatRepositorio)
        {
            _chatRepositorio = chatRepositorio;
        }

        public Task<ChatModel> BuscarConversaPorId(int id)
        {
           return _chatRepositorio.BuscarConversaPorId(id);
        }

        public Task<ChatModel> BuscarConversaPorPergunta(string pergunta)
        {
            return _chatRepositorio.BuscarConversaPorPergunta(pergunta);
        }

        public Task<List<ChatModel>> BuscarTodasConversas()
        {
            return _chatRepositorio.BuscarTodasConversas();
        }
    }
}
