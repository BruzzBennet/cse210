using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address address1= new Address("Bellavista #327","Coatzacoalcos","Veracruz","Mexico");
        Customer customer1= new Customer("Bruce Bennet",address1);
        Order order1 = new Order();
        order1.SetCustomer(customer1);

        Product product1 = new Product(101, "Guillotine", 20, 1);
        Product product2 = new Product(500, "Spray Glue",3,1);
        order1.SetProduct(product1);
        order1.SetProduct(product2);
        order1.ShippingLabel();
        order1.PackingLabel();

        Console.WriteLine();

        Address address2= new Address("Nativitas #803","Albuquerque","New Mexico","USA");
        Customer customer2= new Customer("Sergio Bennetton",address2);
        Order order2 = new Order();
        order2.SetCustomer(customer2);

        Product product3 = new Product(305, "Pencil", 1, 35);
        Product product4 = new Product(600, "CPU",300,1);
        Product product5 = new Product(800, "Gaming Chair",40,2);
        order2.SetProduct(product3);
        order2.SetProduct(product4);
        order2.SetProduct(product5);
        order2.ShippingLabel();
        order2.PackingLabel();
    }
}