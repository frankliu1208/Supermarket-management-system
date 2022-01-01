using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_management_system
{

    /// <summary>
    /// Buy M euro, get N euro
    /// </summary>
    class CalMN : DiscountBase 
    {
        public double M
        {
            get;
            set;
        }

        public double N
        {
            get;
            set;

        }

        public CalMN(double m, double n)
        {
            this.M = m;
            this.N = n;
        }


        public override double GetTotalMoney(double realMoney)
        {
            if(realMoney >= this.M)
            {
                return realMoney - (int)(realMoney/this.M)*this.N;
            }
            else
            {
                return realMoney;
            }



        }
    }
}
