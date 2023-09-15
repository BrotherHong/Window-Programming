using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_2
{
    internal class Stock
    {
        private Dictionary<Commodity, int> stock;
        public Stock()
        {
            stock = new Dictionary<Commodity, int>();
        }

        public void Add(Commodity commodity, int amount)
        {
            if (amount < 0) return;
            if (!stock.ContainsKey(commodity))
            {
                stock[commodity] = amount;
                return;
            }
            stock[commodity] += amount;
        }

        public void Remove(Commodity commodity, int amount)
        {
            if (amount < 0) return;
            if (!stock.ContainsKey(commodity)) return;
            if (!IsEnough(commodity, amount)) return;
            stock[commodity] -= amount;
        }

        public bool IsEnough(Commodity commodity, int amount)
        {
            if (!stock.ContainsKey(commodity)) return false;
            if (amount < 0) return false;
            return amount <= stock[commodity];
        }

        public int RemainAmount(Commodity commodity)
        {
            if (!stock.ContainsKey(commodity)) return -1;
            return stock[commodity];
        }
    }
}
