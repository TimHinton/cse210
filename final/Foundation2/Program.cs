using System;

class Program
{
    static void Main(string[] args)
    {
        Product gizmo = new Product("Gizmo", "001", 4.50, 16);
        Product samoflange = new Product("Samoflange", "002", 17.75, 1);
        Product harness = new Product("Harness", "003", 10.00, 1);
        Product fingerDisplacer = new Product("Finger Displacer", "004", 72.50, 2);
        Product casing = new Product("Casing", "005", 4.99, 2);

        Address oldHouse = new Address("6300 N Windsor st", "Mesa", "AZ", "US");
        Address england = new Address("1010 Werchestershire", "Liverpool", "London", "England");

        Customer john = new Customer();
        john.SetAddress(oldHouse);
        john.SetName("John");

        Order johnOrder = new Order(john);
        johnOrder.AddProduct(samoflange);
        johnOrder.AddProduct(fingerDisplacer);
        johnOrder.AddProduct(casing);

        Customer jane = new Customer();
        jane.SetAddress(england);
        jane.SetName("Jane");

        Order janeOrder = new Order(jane);
        janeOrder.AddProduct(gizmo);
        janeOrder.AddProduct(harness);
        janeOrder.AddProduct(casing);


        johnOrder.CreatePackingLabel();
        johnOrder.CreateShippingLabel();
        johnOrder.CreateReceipt();

        janeOrder.CreatePackingLabel();
        janeOrder.CreateShippingLabel();
        janeOrder.CreateReceipt();

    }
}