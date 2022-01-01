using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_management_system
{
    class SuperMarket
    {
        // 创建仓库对象
        Warehouse ck = new Warehouse();

        /// <summary>
        /// 创建超市对象时，给仓库的货架上导入货物
        /// </summary>
        public SuperMarket()  //创建超市对象时，仓库中有货了
        {
            ck.PurchaseGood("Acer", 1000);
            ck.PurchaseGood("SamSung", 1000);
            ck.PurchaseGood("JiangYou", 1000);
            ck.PurchaseGood("Banana", 1000);
        }

        // 询问用户买什么
        public void AskBuying()
        {
            Console.WriteLine("Herzlich Willkommen, what do you need");
            Console.WriteLine(" we have Acer, Samsung, Jiangyou, Banana");
            string strType = Console.ReadLine();
            Console.WriteLine("How many do you need");
            int count = Convert.ToInt32(Console.ReadLine());

            //到仓库取货
            ProductBase[] pros = ck.TakeGoods(strType, count);

            // 计算价钱
            double realMoney = GetMoney(pros);
            Console.WriteLine("total money you should pay is {0}", realMoney);

            //打折的方式
            Console.WriteLine("please choose the type of discount: 1-- no discount, 2-- 90%, 3--85%, 4--buy 300 euro get 50 euro, 5--buy 500 euro get 100 euro");
            string input = Console.ReadLine();

            // 通过简单工厂的设计模式，根据用户的输入获得一个打折对象
            DiscountBase cal = GetCal(input);
            double totalMoney =  cal.GetTotalMoney(realMoney);
            Console.WriteLine("after discount, you need to pay {0} euro", totalMoney);
        }

        /// <summary>
        /// according to the discount type that user chooses, return an object
        /// </summary>
        /// <param name="input"></param>
        /// <returns> return object of DiscountBase, but actually it is child object</returns>
        public DiscountBase GetCal(string input)   // 返回父类类型对象，实际是子类
        {
            DiscountBase cal = null;
            switch (input)
            {
                case "1": cal = new CalNormal();
                    break;
                case "2":  cal = new CalRate(0.9);
                    break;
                case "3":  cal = new CalRate(0.85);
                    break;
                case "4":  cal = new CalMN(300, 50);
                    break;
                case "5":  cal = new CalMN(500, 100);
                    break;
            }

            return cal;
        }



        /// <summary>
        /// Calculate total sum of money according to what the user buys
        /// </summary>
        /// <param name="pros"></param>
        /// <returns></returns>
        public double GetMoney(ProductBase[] pros)
        {
            double realMoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realMoney += pros[i].Price;
            }

            return realMoney;  //货物的总价
        }

        public void ShowPros()
        {
            ck.ShowPros();
        }


    }
}
