VendingMachine myVendingMachine = new VendingMachine(100);

myVendingMachine.StockFloat(20, 20);
myVendingMachine.StockFloat(10, 20);
myVendingMachine.StockFloat(5, 20);
myVendingMachine.StockFloat(2, 20);
myVendingMachine.StockFloat(1, 20);

Product product1 = new Product("Snickers chocolate bar", 2, "A01");
Product product2 = new Product("Milky Way chocolate bar", 2, "A02");
Product product3 = new Product("Kit Kat chocolate bar", 1, "A03");
Product product4 = new Product("3 Musketers chocolate bar", 2, "A04");
Product product5 = new Product("Hershey's chocolate bar", 3, "A05");
Product product6 = new Product("Twix chocolate bar", 1, "A06");
Product product7 = new Product("Mars chocolate bar", 1, "A07");
Product product8 = new Product("Baby Ruth chocolate bar", 4, "A08");
Product product9 = new Product("Toblerone chocolate bar", 5, "A09");
Product product10 = new Product("Kinder Joy chocolate", 6, "A10");

myVendingMachine.StockItem(product1, 10);
myVendingMachine.StockItem(product2, 10);
myVendingMachine.StockItem(product3, 10);
myVendingMachine.StockItem(product4, 10);
myVendingMachine.StockItem(product5, 10);
myVendingMachine.StockItem(product6, 10);
myVendingMachine.StockItem(product7, 10);
myVendingMachine.StockItem(product8, 10);
myVendingMachine.StockItem(product9, 10);
myVendingMachine.StockItem(product10, 10);

string selectedcode = myVendingMachine.GetCodeProduct();
int paid = myVendingMachine.GetAmountOfPayment();
myVendingMachine.EvaluateCode(selectedcode);



class VendingMachine
{
    public int SerialNumber { get; set; }
    public int MoneyDenomination { get; set; }

    public int CoinsQuantity { get; set; }

    List<int> Payment = new List<int>();

    string SelectedCode { get; set; }

    Dictionary<int, int> MoneyFloat = new Dictionary<int, int>();

    Dictionary<Product, int> Inventory = new Dictionary<Product, int>();

    public VendingMachine(int serialnumber)
    {
        SerialNumber = serialnumber;
    }

    public string StockItem(Product product, int quantity)
    {
        Dictionary<Product, int> Inventory = new Dictionary<Product, int>();

        string productAdded = "";

        Inventory.Add(product, quantity);

        foreach(var item in Inventory)
        {
            productAdded = $"New product available {item.Key.Name}, code {item.Key.Code}, just by ${item.Key.Price}";
          
        }

        Console.WriteLine(productAdded);

        return productAdded;
    }

    public string StockFloat(int moneydenomination, int coinsquantity)
    {
        MoneyDenomination = moneydenomination;

        CoinsQuantity = coinsquantity;

        string stockLegend = "";

        MoneyFloat.Add(moneydenomination, coinsquantity);

        foreach(KeyValuePair<int, int> item in MoneyFloat)
        {
            stockLegend = $"The stock of money availabe in the vending machine is: {item.Value} coins of $ {item.Key} denomination";
        }

        Console.WriteLine(stockLegend);

        return stockLegend;
    }

    public string GetCodeProduct()
    {
        string writedCode = "";
            Console.WriteLine("Please insert the code of the product you want to buy:");
            writedCode = (Console.ReadLine()).ToUpper();
        
        


        return SelectedCode;
    }

    public void EvaluateCode(string selectedcode)
    {
        foreach (var c in Inventory)
        {
            Console.WriteLine(c);
            //if (c.Key.Code == selectedcode)
            //{
            //    Console.WriteLine($"You will buy: {c.Key.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("This product doesn't exist, please insert the correct code");
            //}
        }
    }



    public int GetAmountOfPayment()
    {
        int amount = 0;
        Console.WriteLine("Please insert the amount of payment:");
        Payment.Add(Int32.Parse(Console.ReadLine()));
        foreach(var c in Payment)
        {
            amount = c;
        }
        Console.WriteLine($"you will pay with ${amount}");
        return amount; 
    }

    public string VendItem(string selectedCode, List<int> payment)
    {
        SelectedCode = selectedCode;
        Payment = payment;
        string transactionState = "";
        int CostOfProduct = 0;

    

        //Console.WriteLine("Please insert the amount of payment:");
        //payment = Console.ReadLine();

        //transactionState = $"Please enjoy your {}";
        return null;
    }
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int Quantity { get; set; }

    public string Code { get; set; }

    public Product(string name, int price, string code)
    {
        Name = name;
        Price = price;
        Code = code;
    } 
}


