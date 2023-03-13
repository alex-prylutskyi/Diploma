using Microsoft.AspNetCore.Mvc;
using BookKing.Models.Requests;
using BookKing.DataTransfer;

namespace BookKing.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ItemDto> GetItems()
        {
            return new List<ItemDto>();
        }

        [HttpPost]
        public long CreateItem(ItemDto item)
        {
            return 1;
        }

        [HttpPut]
        public long UpdateItem(ItemDto item)
        {
            return 1;
        }

        [HttpDelete]
        public void DeleteItem(long itemId)
        {
            return;
        }
    }
}
