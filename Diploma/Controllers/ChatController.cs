using Microsoft.AspNetCore.Mvc;
using BookKing.Models.Requests;
using BookKing.DataTransfer;

namespace BookKing.Controllers
{
    [ApiController]
    [Route("chat")]
    public class ChatController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MessageDto> GetMessages(GetMessageRequest getMessageRequest = null)
        {
            //search accounts with filters
            return new List<MessageDto>();
        }

        [HttpPost]
        public void SendMessage(MessageDto message)
        {
            //sendmessage
            return;
        }

        [HttpPost]
        [Route("approve_request")]
        public long AcceptOrderRequest(long orderRequesId)
        {
            //return created orderId
            return orderRequesId;
        }
    }
}
