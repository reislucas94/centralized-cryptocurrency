using CentralizedCryptocurrency.Application.Interfaces;
using CentralizedCryptocurrency.Domain.Entities;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace CentralizedCryptocurrency.Application
{
    public class AccountAppService : IAccountAppService
    {
        public async Task Create(string id)
        {
            var rsaKeys = RSA.Create();

            var newAccount = new Account(id, 
                rsaKeys.ExportRSAPublicKey(), 
                rsaKeys.ExportRSAPrivateKey());

            await Task.Delay(1000);
        }
    }
}
