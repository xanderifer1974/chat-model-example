using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApiChatModel.Models;

namespace webApiChatModel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ChatModel>> BuscarTodasConversas()
        {
            return Ok();
        }
    }
}
