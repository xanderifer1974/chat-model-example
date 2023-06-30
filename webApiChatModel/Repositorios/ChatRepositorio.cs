using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Repositorios.MockBD;

namespace webApiChatModel.Repositorios
{
    public class ChatRepositorio : IChatRepositorio
    {
        private readonly List<ChatModel> _chatDB = ChatBDMock.getChatList();



        public async Task<List<ChatModel>> BuscarTodasConversas()
        {
            return _chatDB.ToList();
        }

        public async Task<ChatModel> BuscarConversaPorId(int id)
        {
            return _chatDB.FirstOrDefault(x => x.IdChat == id);
        }

        public async Task<ChatModel> BuscarConversaPorPergunta(string pergunta)
        {
            ChatModel resposta = new ChatModel();
            var result = _chatDB.Where(e => e.Pergunta.ToUpper().Contains(pergunta.ToUpper())).FirstOrDefault();
            if (result != null)
            {
                resposta = result;
                if (result.IdChat == 2 && !pergunta.Contains("maio de 2023"))
                {
                    resposta.Resposta = "Favor informar o mês da fatura.";
                }

                if (result.IdChat == 3 && !pergunta.Contains("451.745.451-74"))
                {
                    resposta.Resposta = "CPF informado não corresponde a nossa base, favor informar corretamente o seu cpf.";
                }

                if (result.IdChat == 5 && !pergunta.Contains("carlossouza@gmail.com"))
                {
                    resposta.Resposta = "O email informado não corresponde ao e-mail cadastrado. Informe novamente o seu email";
                }

                return resposta;
            }
            else
            {
                resposta.Resposta = "Não temos resposta para sua pergunta, favor reformular a mesma.";
                return resposta;
            }

        }


    }
}
