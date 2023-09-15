using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1
{
    internal class Cart
    {
        private Dictionary<Commodity, int> commodities;

        public Cart()
        {
            this.commodities = new Dictionary<Commodity, int>();
        }

        public void Add(Commodity commodity, int amount)
        {
            if (amount < 0) return;
            if (!commodities.ContainsKey(commodity))
            {
                commodities[commodity] = amount;
                return;
            }
            commodities[commodity] += amount;
        }

        public void Remove(Commodity commodity, int amount)
        {
            if (amount < 0) return;
            if (!commodities.ContainsKey(commodity)) return;
            commodities[commodity] -= amount;
        }

        public Dictionary<Commodity, int> GetCommodities() {  return this.commodities; }

        public double GetTotalCost()
        {
            double totalPrice = 0;
            foreach (KeyValuePair<Commodity, int> element in this.commodities)
            {
                Commodity com = element.Key;
                int amount = element.Value;
                totalPrice += com.GetPrice().GetAmount() * amount;
            }
            return totalPrice;
        }
    }
}
