using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_management_system
{
    /// <summary>
    /// Base class for discount
    /// </summary>
    abstract class DiscountBase
    {
        /// <summary>
        /// calculate the money after discount
        /// </summary>
        /// <param name="realMoney">the money before discount</param>
        /// <returns>the money after the discount</returns>
        public abstract double GetTotalMoney(double realMoney); //get the total money after discount when invoking this method

    }
}
