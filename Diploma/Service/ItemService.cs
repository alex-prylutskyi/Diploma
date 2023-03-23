using BookKing.DataTransfer;
using BookKing.Models;
using BookKing.Repository;
using BookKing.Service.Interfaces;
using Npgsql;

namespace BookKing.Service
{
    public class ItemService : IItemService
    {
        private ItemRepository _itemRepository = new();

        public long CreateItem(ItemDto itemDto)
        {
            return _itemRepository.UpsertItem((Item)itemDto);
        }

        public IEnumerable<Item> GetItems(ItemSearchFilters filters)
        {
            return _itemRepository.ReadItems();
        }

        public long UpdateItem(Item item)
        {
            return _itemRepository.UpsertItem(item);
        }

        public long DeleteItem(long itemId)
        {
            return _itemRepository.DeleteItem(itemId);
        }
    }
}
