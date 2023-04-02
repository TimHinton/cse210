public class Order
{
    private Customer _customer;
    private List<Product> _products;


    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }


    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateOrderTotal()
    {
        double total = 0;
        int shippingCost = 0;

        bool domestic = _customer.GetDomestic();
        if (domestic == true)
        {
            shippingCost = 5;
        } else
        {
            shippingCost = 35;
        }

        foreach (Product product in _products)
        {
            total += product.GetTotalPrice();
        }

        total += shippingCost;

        return total;
    }

    public void CreatePackingLabel()
    {
        Console.WriteLine("\n--------------PACKING LABEL--------------");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetName()} {product.GetID()} : {product.GetQuantity()}");
        }
    }

    public void CreateShippingLabel()
    {
        Console.WriteLine("\n--------------SHIPPING LABEL--------------");
        Console.WriteLine($"{_customer.GetName()} : {_customer.GetAddress()}");
    }

    public void CreateReceipt()
    {
        Console.WriteLine("\nOrder total: " + CalculateOrderTotal());
        Console.WriteLine("");
    }
}