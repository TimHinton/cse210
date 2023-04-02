public class Customer
{
    private string _name;
    private string _address;
    private bool _domestic;

    public Customer()
    {
    }


    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetAddress(Address address)
    {
        _address = address.GetAddress();
        _domestic = address.IsDomestic();
    }
    public string GetAddress()
    {
        return _address;
    }

    public bool GetDomestic()
    {
        return _domestic;
    }
}