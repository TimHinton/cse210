public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productID = id;
        _price = price;
        _quantity = quantity;
    }


    public double GetTotalPrice()
    {
        double cost = _price * _quantity;

        return cost;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }


    public void SetID(string id)
    {
        _productID = id;
    }
    public string GetID()
    {
        return _productID;
    }


    public void SetPrice(float price)
    {
        _price = price;
    }
    public double GetPrice()
    {
        return _price;
    }


    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}