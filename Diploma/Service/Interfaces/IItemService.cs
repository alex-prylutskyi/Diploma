using BookKing.DataTransfer;
using BookKing.Models;

namespace BookKing.Service.Interfaces
{
    public interface IItemService
    {
        public long CreateItem(Item item);

        public IEnumerable<Item> GetItems(ItemSearchFilters filters);

        public long UpdateItem(Item item);

        public long DeleteItem(long itemId);
    }
}
