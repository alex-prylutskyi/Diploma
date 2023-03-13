using Microsoft.AspNetCore.Mvc;
using BookKing.Models.Requests;
using BookKing.DataTransfer;

namespace BookKing.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OrderDto> GetOrders(GetOrdersRequest getOrdersRequest = null)
        {
            //search active, completed orders with filters
            return new List<OrderDto>();
        }

        [HttpPost]
        public long CreateOrderRequest(OrderDto order)
        {
            //create order request
            return 1;
        }

        [HttpPut]
        public long UpdateOrder(OrderDto order)
        {
            //approve order request
            return 1;
        }
    }
}
