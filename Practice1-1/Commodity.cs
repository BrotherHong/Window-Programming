using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Practice1_1
{
    internal class Commodity
    {
        private string _name;
        private Price _price;

        public Commodity(string name, Price price)
        {
            this._name = name;
            this._price = price;
        }

        public string GetName() {  return _name; }
        public Price GetPrice() { return _price; }

        public override bool Equals(Object? obj)
        {
            if (obj == null) return false;
            Commodity commodity = (Commodity) obj;
            return this._name == commodity._name;
        }

        public override string ToString()
        {
            return _name + " " + _price.ToString();
        }
    }

    internal enum CurrencyType
    {
        TWD = 1000, 
        USD = 31, 
        CNY = 230, 
        JPY = 4590,
    }

    internal class Price
    {
        private double _amount;
        private CurrencyType _currency;

        public Price(double amount, CurrencyType currency)
        {
            this._amount = amount;
            this._currency = currency;
        }

        public double GetAmount() { return _amount; }

        public CurrencyType GetCurrency() { return _currency;}

        public void SetCurrency(CurrencyType newCurrency)
        {
            if (this._currency == newCurrency) return;
            double rate = (double)newCurrency / (double)this._currency;
            this._currency = newCurrency;
            this._amount = Tools.FixDouble(this._amount * rate);
        }

        public override string ToString()
        {
            string typeStr = Tools.CurrencyTypeToString(this._currency);
            return string.Format("({0}){1}", typeStr, _amount);
        }
    }
}
