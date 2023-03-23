using BookKing.DataTransfer;
using BookKing.Models;
using System.Security.Principal;

namespace BookKing.Service.Interfaces
{
    public interface IAccountService
    {
        public long CreateAccount(AccountDto itemDto);

        public IEnumerable<Account> GetAccount();

        public long UpdateAccount(Account item);

        public long DeleteAccount(long itemId);
    }
}
