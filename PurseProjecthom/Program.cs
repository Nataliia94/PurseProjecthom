using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesCardLibrary;
using CreditCardLibrary;
using LibraryMoney;

namespace PurseProjecthom
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinesCard businesCard = new BusinesCard();
            businesCard.BCard = "BC1"; Console.WriteLine(businesCard.BCard);
            
            CreditCard creditCard = new CreditCard();
            creditCard.Kreditka = "MasterCard"; Console.WriteLine(creditCard.Kreditka);

            Money money = new Money(); money.Amount = "n5677dhhdhdvdv";Console.WriteLine(money.Amount);

        }
    }
}
