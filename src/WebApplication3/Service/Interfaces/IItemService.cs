using BookKing.DataTransfer;
using BookKing.Models;

namespace BookKing.Service.Interfaces
{
    public interface IItemService
    {
        public long CreateItem(ItemDto itemDto);

        public IEnumerable<Item> GetItems();

        public long UpdateItem(Item item);

        public long DeleteItem(long itemId);
    }
}
