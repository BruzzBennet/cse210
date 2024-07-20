using System.ComponentModel.DataAnnotations;

public class Product{
    private int _product_id;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(int id, string name, int price, int quantity){
        _product_id=id;
        _name=name;
        _price=price;
        _quantity=quantity;
    }

    public string Display(){
        return $"{_quantity} of {_product_id}: {_name} for ${_price}";
    }

    public double GetPrice(){
        return _price*_quantity;
    }
}