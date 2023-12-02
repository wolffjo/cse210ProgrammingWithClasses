class Order
{
    public List<Product> _products = new List<Product>();
    Customer _customer;
    int _totalCost;
    bool USA;

    public int TotalCost()
    {
        USA = _customer.WorldLocation();
        foreach(Product item in _products)
        {
            _totalCost += item.ComputePrice();
        }
        if(USA == true)
        {
            _totalCost += 5;
        }
        else
        {
            _totalCost += 35;
        }
        return _totalCost;
    }

    public string CreateLabel()
    {
        USA = _customer.WorldLocation();
        string label = "";
        if(USA == true)
        {
            foreach(Product item in _products)
            {
                label += $"{item._name}: {item._productID}\n";
            }
        }
        else
        {
            label += _customer._name;
            label += "\n";
            label += _customer._address.HomeAddress();
            label += "\n";
        }
        return label;        
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public Order(Customer customer)
    {
        _customer = customer;
    }
}