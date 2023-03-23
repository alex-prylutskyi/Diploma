namespace BookKing.DataTransfer
{
    public class MessageDto
    {
        public string Message { get; set; }
        public string ReciverId { get; set; }
        public string SenderId { get; set; }
        public DateTime Created { get; set; }
    }
}
