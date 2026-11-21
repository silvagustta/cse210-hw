using System.Collections.Generic;

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

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return total;
    }

    public double GetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public double GetTotalOrderCost()
    {
        return GetTotalCost() + GetShippingCost();
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}