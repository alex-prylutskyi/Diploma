using Microsoft.AspNetCore.Mvc;
using BookKing.Models.Requests;
using BookKing.DataTransfer;
using BookKing.Service;
using BookKing.Models;
using BookKing.Service.Interfaces;

namespace BookKing.Controllers
{
    [ApiController]
    [Route("items")]
    public class ItemController : ControllerBase
    {
        //The logic in the controller layer should primarily be concerned with handling HTTP requests,
        //validating input data, and formatting responses.
        //This layer should not contain any business logic or data access logic.

        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            return Ok(_itemService.GetItems(new ItemSearchFilters()));
        }

        [HttpPost]
        public IActionResult CreateItem(Item item)
        {
            return Ok(_itemService.CreateItem(item));
        }

        [HttpPut]
        public IActionResult UpdateItem(Item item)
        {
            return Ok(_itemService.UpdateItem(item));
        }

        [HttpDelete]
        public IActionResult DeleteItem(long itemId)
        {
            _itemService.DeleteItem(itemId);
            return Ok();
        }
    }
}
