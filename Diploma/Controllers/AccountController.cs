using Microsoft.AspNetCore.Mvc;
using BookKing.Models.Requests;
using BookKing.DataTransfer;

namespace BookKing.Controllers
{
    [ApiController]
    [Route("accounts")]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        [Route("authorize")]
        public string Authorize(string username, string password)
        {
            //login, signup
            return "accessToken";
        }

        [HttpGet]
        public IEnumerable<AccountDto> GetAccounts(GetAccountRequest getAccountRequest = null)
        {
            //search accounts with filters
            return new List<AccountDto>();
        }
    }
}
