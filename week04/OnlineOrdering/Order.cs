using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost: $5 if outside USA, $0 if inside
        if (!_customer.IsInUSA())
        {
            total += 5;
        }

        return total;
    }

    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();
        foreach (var product in _products)
        {
            label.AppendLine($"{product.GetName()} (ID: {product.GetProductId()})");
        }
        return label.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetFullAddress()}";
    }
}

