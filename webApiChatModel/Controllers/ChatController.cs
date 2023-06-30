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
    }
}
