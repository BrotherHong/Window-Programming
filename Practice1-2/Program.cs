using System;
using System.Diagnostics;

namespace Practice1_2
{
    enum Features
    {
        COMMODITY_LIST = 1,
        ADD_TO_CART,
        REMOVE_FROM_CART,
        CHECK_CART,
        CHECK_OUT,
        CONVERT_CURRENCY,
        EXIT,
    }

    enum PaymentMethod
    {
        ONLINE = 1,
        ON_DELIVERY = 2,
    }

    enum Status
    {
        PAYED,
        UNPAID,
    }

    class MainProgram
    {
        static readonly double DISCOUNT = 0.95;
        static readonly string DISCOUNT_CODE = "1111";

        static PaymentMethod paymentMethod = PaymentMethod.ONLINE;
        static Status status = Status.UNPAID;

        static List<Commodity> commodityList = new List<Commodity>()
        {
            new Commodity("潛水相機防丟繩", new Price(199, CurrencyType.TWD)),
            new Commodity("潛水配重帶", new Price(460, CurrencyType.TWD)),
            new Commodity("潛水作業指北針", new Price(1100, CurrencyType.TWD)),
        };

        static void Main(string[] args)
        {
            // define variables
            Stock stock = new Stock();
            Cart cart = new Cart();
            Features feature;

            // initialize
            InitializeCart(cart);
            InitializeStock(stock);

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
                    case Features.CHECK_OUT:
                        CalculateTotalCost(cart, "訂單商品");
                        CheckOut(cart, stock);
                        break;
                    case Features.CONVERT_CURRENCY:
                        ConvertCurrencyValue();
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

        static void InitializeStock(Stock stock)
        {
            stock.Add(commodityList[0], 1);
            stock.Add(commodityList[1], 2);
            stock.Add(commodityList[2], 1);
        }

        static Features AskFeature()
        {
            const string features = "(1)商品列表 (2)新增至購物車 (3)自購物車刪除 (4)查看購物車 (5)結帳 (6)轉換幣值 (7)退出網站";
            Console.WriteLine(features);
            Console.Write("輸入數字選擇功能：");
            int input = int.Parse(Console.ReadLine());
            if (input < 1 || input > 7)
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

        static void CalculateTotalCost(Cart cart, string title)
        {
            // display commodities in cart
            Console.WriteLine(title + "：");
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

        static void CheckOut(Cart cart, Stock stock)
        {
            // variables
            bool hasDiscount = false;

            // ask for check out or not
            Console.Write("*是否要結帳(Y/N)*：");
            string input = Console.ReadLine();
            if (input != "N" && input != "Y")
            {
                Console.WriteLine("輸入錯誤!請重新輸入!");
                return;
            }
            else if (input == "N") return;

            // check stock
            foreach (KeyValuePair<Commodity, int> pair in cart.GetCommodities())
            {
                Commodity commodity = pair.Key;
                int amount = pair.Value;
                if (amount == 0) continue;
                if (!stock.IsEnough(commodity, amount))
                {
                    Console.WriteLine("{0}庫存不足！剩餘數量：{1}！", commodity.GetName(), stock.RemainAmount(commodity));
                    return;
                }
            }

            // choose payment method
            Console.Write("*選擇結帳方式(1.線上支付 2.貨到付款)：");
            int method;
            try
            {
                method = int.Parse(Console.ReadLine()); // assert it's legal
                if (method != 1 && method != 2) throw new Exception("Wrong input");
            } catch (Exception ex)
            {
                Console.WriteLine("輸入錯誤!請重新輸入!");
                return;
            }
            paymentMethod = (PaymentMethod) method;
            status = paymentMethod == PaymentMethod.ONLINE ? Status.PAYED : Status.UNPAID;

            // enter discount code
            Console.Write("*折扣碼(若無折扣碼則輸入N)：");
            input = Console.ReadLine();
            if (input != "N" && input != DISCOUNT_CODE)
            {
                Console.WriteLine("輸入錯誤!請重新輸入!");
                return;
            }
            else if (input == DISCOUNT_CODE) hasDiscount = true;
            Console.WriteLine();

            // print order status
            CalculateTotalCost(cart, "訂單狀態");
            if (hasDiscount)
            {
                double discounted = Tools.FixDouble(cart.GetTotalCost() * DISCOUNT);
                Console.WriteLine("總價(折扣後) = {0}", discounted);
            }
            Console.WriteLine("狀態：{0}", status == Status.PAYED ? "已付款" : "尚未付款");

            // remove commodity from stock
            foreach (KeyValuePair<Commodity, int> pair in cart.GetCommodities())
            {
                Commodity commodity = pair.Key;
                int amount = pair.Value;
                if (amount == 0) continue;
                stock.Remove(commodity, amount);
            }

            // reset cart
            cart.Reset();
        }

        static void ConvertCurrencyValue()
        {
            // ask to select a currency type
            Console.Write("選擇貨幣 1.TWD 2.USD 3.CNY 4.JPY ：");
            int input = int.Parse(Console.ReadLine()); // assert it's legal
            Debug.Assert(1 <= input && input <= 4);

            // get CurrencyType from input string
            CurrencyType currencyType = CurrencyType.TWD;
            switch (input)
            {
                case 1: currencyType = CurrencyType.TWD; break;
                case 2: currencyType = CurrencyType.USD; break;
                case 3: currencyType = CurrencyType.CNY; break;
                case 4: currencyType = CurrencyType.JPY; break;
                default: currencyType = CurrencyType.TWD; break;
            }

            // update currency type
            UpdateCurrencyType(currencyType);
        }

        static void UpdateCurrencyType(CurrencyType currencyType)
        {
            commodityList.ForEach(c => c.GetPrice().SetCurrency(currencyType));
        }
    }
}