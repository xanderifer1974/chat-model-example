using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiChatModel.Models;
using webApiChatModel.Repositorios;
using webApiChatModel.Repositorios.Interfaces;

namespace webApiChatModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatRepositorio _chatRepositorio;

        public ChatController(IChatRepositorio chatRepositorio)
        {
            _chatRepositorio = chatRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ChatModel>>>  BuscarTodasConversas()
        {
           List<ChatModel> listChat = await _chatRepositorio.BuscarTodasConversas();

            return Ok(listChat);
        }

        [HttpGet("buscarPorId/{id}")]
        public async Task<ActionResult<ChatModel>> BuscarConversaPorId(int id)
        {
            ChatModel chat = await _chatRepositorio.BuscarConversaPorId(id);

            return Ok(chat);
        }

        [HttpGet("buscarPorPergunta/{pergunta}")]
        public async Task<ActionResult<ChatModel>> BuscarConversaPorPergunta(string pergunta)
        {
            ChatModel chat = await _chatRepositorio.BuscarConversaPorPergunta(pergunta);

            return Ok(chat);
        }
    }
}
