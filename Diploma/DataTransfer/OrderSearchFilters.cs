using System.Xml.XPath;

namespace BookKing.DataTransfer
{
    public class OrderSearchFilters
    {
        public long AccountId { get; set; }
        public long OrderId { get; set; }
        public long ItemName { get; set; }
        public PriceRange PriceRange { get; set; } = new();
    }

    public class PriceRange
    {
        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }
    }
}
