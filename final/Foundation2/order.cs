using System.Runtime.CompilerServices;

public class Order{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _total_price;
    private int _shipping_cost;

    public void SetCustomer(Customer customer){
        _customer=customer;
    }
    
    public void SetProduct(Product product){
        _products.Add(product);
    }

    public double TotalPrice(){
        foreach (Product item in _products){
            _total_price+=item.GetPrice();
        }
        if (_customer.IsFromUSA())
            _shipping_cost=5;
        else
            _shipping_cost=35;
        return _total_price+_shipping_cost;
    }

    public void ShippingLabel(){
        Console.WriteLine(_customer.Display());
    }

    public void PackingLabel(){
        foreach (Product item in _products){
            Console.WriteLine(item.Display());
        }
        Console.WriteLine($"Total Price: ${TotalPrice()}");
        Console.WriteLine($"Subtotal: ${_total_price}");
        Console.WriteLine($"Shipping Cost: ${_shipping_cost}");
    }
}