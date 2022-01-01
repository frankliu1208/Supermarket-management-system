using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_management_system
{
    class CalRate : DiscountBase
    {
        /// <summary>
        /// conduct discount according to discount rate
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>

        public double Rate
        {
            get;
            set;
        }

        public CalRate(double rate)  //创建对象时，传入折扣率，并将折扣率赋值给属性Rate
        {
            this.Rate = rate;    
        }


        public override double GetTotalMoney(double realMoney)
        {
            return realMoney * this.Rate;
        }
    }
}
