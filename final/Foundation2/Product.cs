public class Product
{
    public string _name;
    public string _productID;
    int _price;
    int _quantity;

    void Display()
    {

    }

    public int ComputePrice()
    {
        int finalPrice = _price * _quantity;
        return finalPrice;
    }

    public Product(string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
}