using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_2
{
    internal class Tools
    {
        public static string CurrencyTypeToString(CurrencyType currency)
        {
            switch (currency)
            {
                case CurrencyType.TWD: return "TWD";
                case CurrencyType.USD: return "USD";
                case CurrencyType.CNY: return "CNY";
                case CurrencyType.JPY: return "JPY";
            }
            throw new Exception("CurrencyType to string converting error");
        }

        public static double FixDouble(double num)
        {
            const double ERR = 0.000001;
            const double PRECISE = 1e3; 

            num *= PRECISE; // precise to three decimal places
            
            if (num - Math.Floor(num) <= ERR)
            {
                return Math.Floor(num) / PRECISE;
            }
            if (Math.Ceiling(num) - num <= ERR)
            {
                return Math.Ceiling(num) / PRECISE;
            }
            return num / PRECISE;
        }
    }
}
