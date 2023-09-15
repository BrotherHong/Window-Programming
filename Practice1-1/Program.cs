using System;
using System.Diagnostics;
using Practice1_1;

namespace Practice1_1
{
    enum Features
    {
        COMMODITY_LIST = 1,
        ADD_TO_CART,
        REMOVE_FROM_CART,
        CHECK_CART,
        CALCULATE_TOTAL_COST,
        EXIT,
    };

    class MainProgram
    {
        static List<Commodity> commodityList = new List<Commodity>()
        {
            new Commodity("潛水相機防丟繩", new Price(199, CurrencyType.TWD)),
            new Commodity("潛水配重帶", new Price(460, CurrencyType.TWD)),
            new Commodity("潛水作業指北針", new Price(1100, CurrencyType.TWD)),
        };

        static void Main(string[] args)
        {
            // define variables
            Cart cart = new Cart();
            Features feature;

            // initialize cart
            InitializeCart(cart);

            // app-scale while loop
            bool exit = false;
            while (true)
            {
                // choose feature
                while (true)
                {
                    try
                    {
                        feature = AskFeature();
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("輸入錯誤!請重新輸入!");
                        Console.WriteLine();
                    }
                }

                // execute feature
                switch (feature)
                {
                    case Features.COMMODITY_LIST:
                        DisplayCommodityList();
                        break;
                    case Features.ADD_TO_CART:
                        AddCommodityToCart(cart);
                        break;
                    case Features.REMOVE_FROM_CART:
                        RemoveCommodityFromCart(cart);
                        break;
                    case Features.CHECK_CART:
                        CheckCart(cart);
                        break;
                    case Features.CALCULATE_TOTAL_COST:
                        CalculateTotalCost(cart);
                        break;
                    case Features.EXIT:
                        exit = true;
                        break;
                }

                if (exit) break;
                Console.WriteLine();
            }

            Console.Read();
        }

        static void InitializeCart(Cart cart)
        {
            foreach (Commodity commodity in commodityList)
            {
                cart.Add(commodity, 0);
            }
        }

        static Features AskFeature()
        {
            const string features = "(1)商品列表 (2)新增至購物車 (3)自購物車刪除 (4)查看購物車 (5)計算總金額 (6)退出網站";
            Console.WriteLine(features);
            Console.Write("輸入數字選擇功能：");
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 6)
            {
                throw new Exception("Out of available range");
            }
            return (Features)input;
        }

        static void DisplayCommodityList()
        {
            Console.WriteLine("列表:");
            Console.WriteLine("商品名稱 商品單價");
            for (int i = 0; i < commodityList.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i+1, commodityList[i]);
            }
        }

        static void AddCommodityToCart(Cart cart)
        {
            // display all commodities with number
            for (int i = 0; i < commodityList.Count; i++)
            {
                Console.Write("({0}){1} ", i+1, commodityList[i].GetName());
            }
            Console.WriteLine();

            // ask commodity
            Console.Write("輸入數字選擇物品：");
            int tag = int.Parse(Console.ReadLine()); // assert it's legal
            Debug.Assert(1 <= tag && tag <= 3);

            // ask amount
            Console.Write("輸入數量：");
            int amount = int.Parse(Console.ReadLine()); // assert it's legal
            Debug.Assert(1 <= amount && amount <= 5);

            // add to cart
            cart.Add(commodityList[tag - 1], amount);
        }

        static void RemoveCommodityFromCart(Cart cart)
        {
            // display cart content
            CheckCart(cart);

            // ask commodity to remove (may have exception)
            Console.Write("輸入數字選擇商品：");
            int tag = int.Parse(Console.ReadLine()); // assert it's legal
            if (tag <= 0 || tag > commodityList.Count)
            {
                Console.WriteLine("輸入錯誤!請重新輸入!");
                return;
            }

            // ask amount
            Console.Write("輸入數量：");
            int amount = int.Parse(Console.ReadLine()); // assert it's legal

            // remove it from cart
            cart.Remove(commodityList[tag - 1], amount);
            Console.WriteLine("成功刪除物品!");
        }

        static void CheckCart(Cart cart)
        {
            Console.WriteLine("購物車內容：");
            Console.WriteLine("商品 單價 數量 小計");
            int tag = 1;
            foreach (KeyValuePair<Commodity, int> pair in cart.GetCommodities())
            {
                Commodity commodity = pair.Key;
                int amount = pair.Value;
                double subTotal = commodity.GetPrice().GetAmount() * amount;
                Console.WriteLine("{0}.{1} {2} {3}", tag++, commodity, amount, subTotal);
            }
        }

        static void CalculateTotalCost(Cart cart)
        {
            // display commodities in cart
            Console.WriteLine("訂單商品：");
            Console.WriteLine("商品 單價 數量 小計");
            foreach (KeyValuePair<Commodity, int> pair in cart.GetCommodities())
            {
                Commodity commodity = pair.Key;
                int amount = pair.Value;

                if (amount == 0) continue;

                double subTotal = commodity.GetPrice().GetAmount() * amount;
                Console.WriteLine("{0} {1} {2}", commodity, amount, subTotal);
            }

            // print total cost
            double cost = cart.GetTotalCost();
            Console.WriteLine("總價 = {0}", cost);
        }

        static void UpdateCurrencyType(CurrencyType currencyType)
        {
            commodityList.ForEach(c => c.GetPrice().SetCurrency(currencyType));
        }
    }
}