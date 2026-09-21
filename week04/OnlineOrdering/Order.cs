using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public List<Product> Products
    {
        get { return _products; }
        set { _products = value; }
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalPrice()
    {
        decimal total = _customer.LivesInUSA() ? 5m : 35m;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        foreach (Product product in _products)
        {
            label.AppendLine($"{product.Name} ({product.ProductId})");
        }

        return label.ToString().TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.Name}\n{_customer.Address.GetAddressString()}";
    }
}