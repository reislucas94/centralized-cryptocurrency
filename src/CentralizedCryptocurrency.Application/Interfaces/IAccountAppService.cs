using System;
using System.Threading.Tasks;

namespace CentralizedCryptocurrency.Application.Interfaces
{
    public interface IAccountAppService
    {
        Task Create(string id);
    }
}
