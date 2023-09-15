using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1
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
            if (num - Math.Floor(num) <= ERR)
            {
                return Math.Floor(num);
            }
            if (Math.Ceiling(num) - num <= ERR)
            {
                return Math.Ceiling(num);
            }
            return num;
        }
    }
}
