using System;

namespace Supermarket_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sm = new SuperMarket();
            sm.ShowPros();
            sm.AskBuying();  //Interact with the user

            Console.ReadKey();
        }
    }
}
