public class Address
{
    string _street;
    string _city;
    string _state;
    string _province;
    string _country;
    bool USA;
    string _homeAddress;

    void Display()
    {

    }

    public string HomeAddress()
    {
        if(_country == "USA")
        {
            _homeAddress = $"{_street}\n{_city}, {_state}\n{_country}";
        }
        else
        {
            _homeAddress = $"{_street}\n{_city}, {_province}\n{_country}";
        }
        
        return _homeAddress;
    }

    public bool WorldLocation() //:)
    {
        if(_country == "USA")
        {
            USA = true;
        }
        else
        {
            USA = false;
        }
        return USA;
    }
    

    public Address(string street, string city, string state)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = "USA";
    }

    public Address(string street, string city, string province, string country)
    {
        _street = street;
        _city = city;
        _province = province;
        _country = country;
    }
}