using System;

namespace Supermarket_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sm = new SuperMarket();
            sm.ShowPros();
            sm.AskBuying();  //用户交互

            Console.ReadKey();
        }
    }
}
