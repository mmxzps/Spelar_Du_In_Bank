﻿using Spelar_Du_In_Bank.Utilities;
using Spelar_Du_In_Bank.Data;
using Spelar_Du_In_Bank.Model;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;


namespace BankBootstrap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuAction myMeny = new MenuAction();
            myMeny.Start();
        }

    }
}