using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_management_system
{
    class CalNormal : DiscountBase
    {
        /// <summary>
        /// there is no discount
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
