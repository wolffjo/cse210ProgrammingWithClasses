using System.Runtime.CompilerServices;

class Customer
{
    public string _name;
    public Address _address;
    bool USA;

    public bool WorldLocation()
    {
        USA = _address.WorldLocation();
        return USA;
    }

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}