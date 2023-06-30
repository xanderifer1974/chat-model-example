using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.MockBD
{
    public static class ChatBDMock
    {
        public static  List<ChatModel> getChatList()
        {
            List<ChatModel> listaChat = new List<ChatModel>();

            ChatModel conversa1 = new ChatModel(1, "Bom dia", "Bom dia, o que podemos ajudar?");
            ChatModel conversa2 = new ChatModel(2, "Preciso de uma segunda via da fatura do mês de maio/2023", "Favor informar o seu CPF");
            ChatModel conversa3 = new ChatModel(3, "451.745.451-74", "Seu nome é Carlos Augusto Souza?");
            ChatModel conversa4 = new ChatModel(4, "Isso mesmo", "Preciso que você me informe um e-mail para envio.");
            ChatModel conversa5 = new ChatModel(5, "Sim, meu email é carlossouza@gmail.com", "Só um instante Sr. Carlos, que enviaremos o email.");
            ChatModel conversa6 = new ChatModel(6, "Sim, no aguardo", "Sr. Carlos, acabamos de enviar o e-mail. Favor checar sua caixa de mensagem.");
            ChatModel conversa7 = new ChatModel(7, "Recebi o e-mail com a fatura, obrigado", "Nós que agradecemos em poder ajudar.");

            listaChat.Add(conversa1);
            listaChat.Add(conversa2);
            listaChat.Add(conversa3);
            listaChat.Add(conversa4);
            listaChat.Add(conversa5);
            listaChat.Add(conversa6);
            listaChat.Add(conversa7);

            return listaChat;
        }
    }
}
