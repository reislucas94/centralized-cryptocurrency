﻿using System;
using System.ComponentModel;

namespace CentralizedCryptocurrency.Core
{
    public class Account
    {
        public Guid Id { get; set; }
        public string PublicKey { get; set; }
        public string PrivateKey { get; set; }
    }
}