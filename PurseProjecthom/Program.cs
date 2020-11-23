using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinesCardLibrary;
using CreditCardLibrary;

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

        }
    }
}
