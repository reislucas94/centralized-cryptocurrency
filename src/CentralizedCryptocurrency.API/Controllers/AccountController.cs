using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentralizedCryptocurrency.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CentralizedCryptocurrency.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Account> GetAllAccounts()
        {
            IEnumerable<Account> accounts = new List<Account>();

            var account = new Account();

            account.Id = Guid.NewGuid();
            account.PublicKey = "public";
            account.PrivateKey = "private";

            return accounts.Append(account);
        }
    }
}
