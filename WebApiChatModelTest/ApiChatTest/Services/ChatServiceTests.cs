using Moq;
using webApiChatModel.Models;
using webApiChatModel.Repositorios.Interfaces;
using webApiChatModel.Services;
using Xunit;

namespace WebChatTest.ApiChatTest.Services
{
    public class ChatServiceTests
    {
        private readonly Mock<IChatRepositorio> _chatRepositorioMock;
        private readonly Mock<IClienteRepositorio> _clienteRepositorioMock;

        public ChatServiceTests()
        {
            _chatRepositorioMock = new Mock<IChatRepositorio>();
            _clienteRepositorioMock = new Mock<IClienteRepositorio>();
        }

        [Fact]
        public async Task BuscarConversaPorId_DeveRetornarChatModel()
        {
            // Arrange
            int id = 1;
            var chatModelEsperado = new ChatModel();
            _chatRepositorioMock.Setup(repo => repo.BuscarConversaPorId(id)).Returns(chatModelEsperado);
            var chatService = new ChatService(_chatRepositorioMock.Object, _clienteRepositorioMock.Object);

            // Act
            var resultado = await chatService.BuscarConversaPorId(id);

            // Assert
            Assert.Equal(chatModelEsperado, resultado);
        }

        [Fact]
        public async Task BuscarConversaPorPergunta_DeveRetornarChatModel()
        {
            // Arrange
            string pergunta = "Qual é a pergunta?";
            var chatModelEsperado = new ChatModel();
            _chatRepositorioMock.Setup(repo => repo.BuscarConversaPorPergunta(pergunta)).Returns(chatModelEsperado);
            var chatService = new ChatService(_chatRepositorioMock.Object, _clienteRepositorioMock.Object);

            // Act
            var resultado = await chatService.BuscarConversaPorPergunta(pergunta);

            // Assert
            Assert.Equal(chatModelEsperado, resultado);
        }

       
        //[Fact]
        //public async Task BuscarConversaPorPergunta_DeveRetornarRespostaQuandoCPFValido()
        //{
        //    // Arrange
        //    string pergunta = "12345678901"; // CPF válido
        //    var clienteModel = new ClienteModel { Nome = "João" };
        //    _clienteRepositorioMock.Setup(repo => repo.ObterClientePorCPF(It.IsAny<long>())).Returns(clienteModel);
        //    var chatService = new ChatService(_chatRepositorioMock.Object, _clienteRepositorioMock.Object);

        //    // Act
        //    var resultado = await chatService.BuscarConversaPorPergunta(pergunta);

        //    // Assert
        //    Assert.NotNull(resultado);
        //    Assert.Equal($"<h6>Olá {clienteModel.Nome}, escolha uma das opções abaixo.</h6>", resultado.Resposta);
        //}
    }
}
