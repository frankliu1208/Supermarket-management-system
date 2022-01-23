using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_management_system
{
    class Warehouse
    {
        List<List<ProductBase>> list = new List<List<ProductBase>>(); 


        public void ShowPros()  //向用户展示货物 Show products to the User
        {
            foreach (var item in list)
            {
                Console.WriteLine("in our warehouse there is:" + item[0].Name + "," + "\t" + "number:" + item.Count);
            }
        }



        public Warehouse()    //When creating the warehouse object, invode this contruction function, creates 4 shelves
        {
            list.Add(new List<ProductBase>());  
            list.Add(new List<ProductBase>());
            list.Add(new List<ProductBase>());
            list.Add(new List<ProductBase>());
        }

        /// <summary>
        /// purchase the goods
        /// </summary>
        /// <param name="strType">Type of goods</param>
        /// <param name="count">The number of goods that is purchased</param>
        public void PurchaseGood(string strType, int count)     
        {
            for(int i=0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "computer1"));
                        break;
                    case "SamSung": list[1].Add(new SamSung(Guid.NewGuid().ToString(), 2000, "SamSung cell phone 2"));
                        break;
                    case "SoySauce": list[2].Add(new SoySauce(Guid.NewGuid().ToString(), 200, "SoySause3"));
                        break;
                    case "Banana": list[3].Add(new Banana(Guid.NewGuid().ToString(), 500, "Banana4"));
                        break;
                } 

            }
        }

        /// <summary>
        /// Take the goods out
        /// </summary>
        /// <param name="strType"></param>
        /// <param name="count"></param>
        public ProductBase[] TakeGoods(string strType, int count)
        {
            ProductBase[] pros = new ProductBase[count];
            for (int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer": pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "SamSung": pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;

                    case "SoySauce": pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "Banana": pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }

            return pros;

        }


    }
}
