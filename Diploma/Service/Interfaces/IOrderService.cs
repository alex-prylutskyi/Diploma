using BookKing.DataTransfer;
using BookKing.Enums;
using BookKing.Models;

namespace BookKing.Service.Interfaces
{
    public interface IOrderService
    {
        public void ApproveOrderRequest(long orderId, long customerAccountId);

        public void CreateOrderRequest(long itemId, long accountId, decimal price);

        public void GetOrders(OrderSearchFilters filters);

        public void UpdateOrderRequest(Order order);
        
        public void DeleteOrderRequest(long orderId);
    }
}
