﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountManager accountManager = new AccountManager();
            accountManager.selectOperations();
        }
    }
}
