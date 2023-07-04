using webApiChatModel.Models;

namespace webApiChatModel.Repositorios.MockBD
{
    public static class ChatBDMock
    {
        public static  List<ChatModel> getChatList()
        {
            List<ChatModel> listaChat = new List<ChatModel>();

            ChatModel conversa1 = new ChatModel(1, "Bom dia", "Bom dia, o que podemos ajudar?");
            ChatModel conversa2 = new ChatModel(2, "Preciso da fatura de maio de 2023", "Favor informar o seu CPF");
            ChatModel conversa3 = new ChatModel(3, "451.745.451-74", "Seu nome é Carlos Augusto Souza?");
            ChatModel conversa4 = new ChatModel(4, "Sim, isso mesmo", "Preciso que você me informe um e-mail para envio");
            ChatModel conversa5 = new ChatModel(5, "Sim, meu email é carlossouza@gmail.com", "Só um instante Sr. Carlos, que enviaremos o email.");
            ChatModel conversa6 = new ChatModel(6, "Sim, no aguardo", "Sr. Carlos, acabamos de enviar o e-mail. Favor checar sua caixa de mensagem.");
            ChatModel conversa7 = new ChatModel(7, "Recebi o e-mail com a fatura, obrigado", "Nós que agradecemos em poder ajudar.");
            ChatModel conversa8 = new ChatModel(7, "Gostaria de atualizar os dados de cadastro.", "Favor nos enviar os dados em arquivo. ");

            listaChat.Add(conversa1);
            listaChat.Add(conversa2);
            listaChat.Add(conversa3);
            listaChat.Add(conversa4);
            listaChat.Add(conversa5);
            listaChat.Add(conversa6);
            listaChat.Add(conversa7);
            listaChat.Add(conversa8);

            return listaChat;
        }

        public static List<ClienteModel> getClienteList()
        {
            List<ClienteModel> listCliente = new List<ClienteModel>();

            ClienteModel cliente1 = new ClienteModel(1, 19498820000183, "Antonio Figueiredo de Oliveira","Antonio", true);
            ClienteModel cliente2 = new ClienteModel(2, 32722766000176, "Graziela Lopes Nunes","Graziela", true);
            ClienteModel cliente3 = new ClienteModel(3, 25236478000146, "Paulo Roberto Silva Santos","Paulo Roberto", true);
            ClienteModel cliente4 = new ClienteModel(4, 37081595000167, "João Paulo Martins", "João Paulo", true);
            ClienteModel cliente5 = new ClienteModel(5, 33763302000170, "Amanda Bitencourt de Azevedo", "Amanda",true);
            ClienteModel cliente6 = new ClienteModel(6, 30436053000110, "Simone Cury Machado","Simone", true);
            ClienteModel cliente7 = new ClienteModel(7, 93121570000110, "Gabriel Marcos Limeira","Gabriel Marcos", true);
            ClienteModel cliente8 = new ClienteModel(8, 32985744000107, "Rafael Pedreira de Souza","Rafael", true);
            ClienteModel cliente9 = new ClienteModel(9, 96564711000168, "Lucia das Neves Ferreira","Lucia", true);
            ClienteModel cliente10 = new ClienteModel(10, 90409115000127, "Ezequiel Medeiros Mendonza","Ezequiel", true);

            listCliente.Add(cliente1);
            listCliente.Add(cliente2);
            listCliente.Add(cliente3);
            listCliente.Add(cliente4);
            listCliente.Add(cliente5);
            listCliente.Add(cliente6);
            listCliente.Add(cliente7);
            listCliente.Add(cliente8);
            listCliente.Add(cliente9);
            listCliente.Add(cliente10);

            return listCliente;

        }
    }
}
