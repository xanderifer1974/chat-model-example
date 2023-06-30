namespace webApiChatModel.Models
{
    public class ChatModel
    {
        public int IdChat { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }

        public ChatModel(int idChat, string pergunta, string resposta)
        {
            IdChat = idChat;
            Pergunta = pergunta;
            Resposta = resposta;
        }

    }
}
