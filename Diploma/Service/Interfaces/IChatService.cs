namespace BookKing.Service.Interfaces
{
    public interface IChatService
    {
        public void SendMessage(string message, string senderAccountId, string recieverAccountId);
    }
}
