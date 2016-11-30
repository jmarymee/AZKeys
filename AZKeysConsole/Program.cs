using System;
using System.Collections.Generic;
using System.Text;
using AZKeys;

namespace AZKeysConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string storePath = @"C:\tools\keys.xml";
            AZKeys.AZKeys keys = new AZKeys.AZKeys()
            { azStorageAccountName = "unityscores", azStoragePrimaryKey = "qevOBB7bEvX69HG18vROe1rQLjZM7ZfLXuW9aOpmAgHnq/XMyuBx/fdagQ4ytWISaksMVKphMlICfPho8/CUIg==" };

            AZKeysClass az = new AZKeysClass();
            az.StoreKeys(keys, storePath);

            AZKeys.AZKeys key2 = az.GetSecrets(storePath);

        }
    }
}
