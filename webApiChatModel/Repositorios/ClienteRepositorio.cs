using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Repositorios.MockBD;

namespace webApiChatModel.Repositorios
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        
        public Task<List<ClienteModel>> ListarTodosClientes()
        {
            List<ClienteModel> list = ChatBDMock.getClienteList();

            return  Task.FromResult(list);

        }

        public Task<ClienteModel> ObterClientePorCPF(long cpf)
        {
          
          ClienteModel cliente = ChatBDMock.getClienteList().FirstOrDefault(c => c.Cpf == cpf);

            return Task.FromResult(cliente);
        }

        public bool VerificaCpfCadastrado(long cpf)
        {
            int QtdCpfCadastrado = ChatBDMock.getClienteList().Where(c => c.Cpf == cpf).Count();

            if(QtdCpfCadastrado > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
