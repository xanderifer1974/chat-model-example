using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Repositorios.MockBD;
using webApiChatModel.Util;

namespace webApiChatModel.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        
        public List<ClienteModel> ListarTodosClientes()
        {
            List<ClienteModel> list = ChatBDMock.getClienteList();

            return  list;

        }

        public ClienteModel ObterClientePorCPF(long cpf)
        {
            //Valida o CPF
            if (UtilApi.ValidaCPF(cpf.ToString()))
            {
                throw new ArgumentException("CPF inválido");
            }
          
          ClienteModel cliente = ChatBDMock.getClienteList().FirstOrDefault(c => c.Cpf == cpf);

            if(cliente == null)
            {
                throw new InvalidOperationException("Cliente não encontrado");
            }         


          return cliente;
        }       
    }
}
