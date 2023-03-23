namespace BookKing.DataTransfer
{
    public class OrderDto
    {
        public long ItemId { get; set; }
        public long CustomerAccountId { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Status { get; set; }
    }
}
