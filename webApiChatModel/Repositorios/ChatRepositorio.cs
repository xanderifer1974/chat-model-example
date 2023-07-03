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
            ChatModel chat = new ChatModel();
            chat.Pergunta = pergunta;           
            string nomeArquivo = "";

            if (pergunta.StartsWith("Arquivo selecionado:"))
            {
                int indiceDoisPontos = pergunta.IndexOf(':');

                if (indiceDoisPontos != -1 && indiceDoisPontos < pergunta.Length - 1)
                {
                    nomeArquivo = pergunta.Substring(indiceDoisPontos + 1).Trim();
                    
                }

                chat.Pergunta = pergunta;
                chat.Resposta = $"Recebemos o arquivo {nomeArquivo} com sucesso!";

            }
            else
            {
                chat = pesquisarPergunta(chat);
               
            }
           

            return chat;

        }

        private ChatModel pesquisarPergunta(ChatModel chatModel)
        {
            var result = _chatDB.Where(e => e.Pergunta.ToUpper().Contains(chatModel.Pergunta.ToUpper())).FirstOrDefault();
            if (result != null)
            {
               
                if (result.IdChat == 2 && !chatModel.Pergunta.Contains("maio de 2023"))
                {
                    chatModel.Resposta = "Favor informar o mês da fatura.";
                    return chatModel;
                }

                if (result.IdChat == 3 && !chatModel.Pergunta.Contains("451.745.451-74"))
                {
                    chatModel.Resposta = "CPF informado não corresponde a nossa base, favor informar corretamente o seu cpf.";
                    return chatModel;
                }

                if (result.IdChat == 5 && !chatModel.Pergunta.Contains("carlossouza@gmail.com"))
                {
                    chatModel.Resposta = "O email informado não corresponde ao e-mail cadastrado. Informe novamente o seu email";
                    return chatModel;
                }               
            }
            else
            {
                chatModel.Resposta = "Não temos resposta para sua pergunta, favor reformular a mesma.";
                return chatModel;
            }

            return result;
        }


    }
}
