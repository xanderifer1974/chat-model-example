using webApiChatModel.Models;
using webApiChatModel.Repositorios;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Services.Interface;

namespace webApiChatModel.Services
{
    public class ChatService: IChatService
    {
        private readonly IChatRepositorio _chatRepositorio;
        private readonly IClienteRepositorio _clienteRepositorio;

        public ChatService(IChatRepositorio chatRepositorio, IClienteRepositorio clienteRepositorio)
        {
            _chatRepositorio = chatRepositorio;
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<ChatModel> BuscarConversaPorId(int id)
        {
           return await Task.FromResult(_chatRepositorio.BuscarConversaPorId(id));
        }

        public async Task<ChatModel> BuscarConversaPorPergunta(string pergunta)
        {
            ChatModel model = new ChatModel();
            model = _chatRepositorio.BuscarConversaPorPergunta(pergunta);
            return await Task.FromResult(model);
        }

        public async Task<List<ChatModel>> BuscarTodasConversas()
        {
            return await Task.FromResult(_chatRepositorio.BuscarTodasConversas());
        }
    }
}
