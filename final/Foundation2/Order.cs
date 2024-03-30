using System;

class Order
{
    // variables
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // add products
    public void AddProduct(Product product){
        _products.Add(product);
    }

    // total order cost
    public double ProductTotal(){
        double totalPrice = 0;
        foreach (Product product in _products){
            totalPrice += product.GetProductTotal();
        }
        if (_customer.IsInUSA()){
            totalPrice += 5;
        }
        else{
            totalPrice += 35;
        }
        return totalPrice;
    }
    
    // packing label
    public List<string> PrintPackingLabel(){
        List<string> packingLabels = new List<string>();
        foreach(Product product in _products){
            string productLabel = $"    Product Name: {product.GetName()}, Product ID: {product.GetProductId()}";
            packingLabels.Add(productLabel);
        }
        return packingLabels;
    }

    // shipping label
    public string PrintShippingLabel(){
        return $"Shipping Label: \n    {_customer.GetName()} - {_customer.GetAddress()}";
    }

}