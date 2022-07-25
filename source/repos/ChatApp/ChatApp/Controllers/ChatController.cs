using ChatApp.Dtos;
using ChatApp.Entity;
using ChatApp.Extention;
using ChatApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ChatApp.Controllers
{
    [ApiController]
    [Route("chat")]
    public class ChatController : ControllerBase
    {
        private readonly IMessageRepository messageRepository;

        public ChatController(IMessageRepository messageRepository)
        {
            this.messageRepository = messageRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok((await messageRepository.GetAllMessage()).Select(p => p.ChatToDto()).ToList());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetId(Guid id)
        {
            var item = await messageRepository.GetAllMessageByID(id);

            if (item == null)
            {
                return BadRequest();
            }
            return Ok(item);
        }
        [HttpPost]
        public IActionResult Post(CreatMessage creat)
        {
            var entity = new ChatEntity 
            { id=Guid.NewGuid(),
            Name=creat.Name,
            Message=creat.Message
            };
            messageRepository.CreatMessage(entity);
           return Ok(entity);
        }
    }
}
