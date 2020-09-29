using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentralizedCryptocurrency.Application.Interfaces;
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
        private readonly IAccountAppService _accountAppService;

        public AccountController(ILogger<AccountController> logger,
            IAccountAppService accountAppService)
        {
            _logger = logger;
            _accountAppService = accountAppService;
        }

        [HttpGet]
        public IEnumerable<Account> GetAllAccounts()
        {
            IEnumerable<Account> accounts = new List<Account>();

            var account = new Account(Guid.NewGuid().ToString(), null, null);

            return accounts.Append(account);
        }

        [HttpPost("create")]
        public async Task Create(string id)
        {
            await _accountAppService.Create(id);
        }
    }
}
