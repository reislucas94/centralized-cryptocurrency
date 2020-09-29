using System;
using System.ComponentModel;

namespace CentralizedCryptocurrency.Domain.Entities
{
    public class Account
    {
        public string Id { get; private set; }
        public byte[] PublicKey { get; private set; }
        public byte[] PrivateKey { get; private set; }

        public Account (string id, byte[] publicKey, byte[] privateKey)
        {
            Id = id;
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }
    }
}
