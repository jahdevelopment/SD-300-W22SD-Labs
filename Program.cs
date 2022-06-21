class VendingMachine
{
    public int SerialNumber { get; set; }

    Dictionary<int, int> MoneyFloat = new Dictionary<int, int>();

    Dictionary<Product, int> Inventory = new Dictionary<Product, int>();

    public string StockItem(Product product, int quantity)
    {
        return 
    }

    public string StockFloat(int moneyDenomination, int quantity)
    {
        return
    }

     public string VendItem(string code, List<int> money)
    {
        return
    }
}

class Product
{
    public string Name { get; set; }
    public int Price { get; set; }

    public int Quantity { get; set; }

    public string Code { get; set; }


}

