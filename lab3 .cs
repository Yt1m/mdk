using System;

class Goods
{
    private string productName;
    private DateTime dateOfPurchase;
    private double price;
    private int quantity;
    private string invoiceNumber;


    public Goods(string productName, DateTime dateOfPurchase, double price, int quantity, string invoiceNumber)
    {
        this.productName = productName;
        this.dateOfPurchase = dateOfPurchase;
        this.price = price;
        this.quantity = quantity;
        this.invoiceNumber = invoiceNumber;
    }

    public void ChangePrice(double newPrice)
    {
        price = newPrice;
    }

    public void IncreaseQuantity(int amount)
    {
        quantity += amount;
    }

    public void DecreaseQuantity(int amount)
    {
        if (quantity >= amount)
        {
            quantity -= amount;
        }
        else
        {
            Console.WriteLine("Недостаточное количество товара для уменьшения.");
        }
    }


    public double CalculateTotalPrice()
    {
        return price * quantity;
    }


    public override string ToString()
    {
        return $"Наименование товара: {productName}, Стоимость товара: {CalculateTotalPrice()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
  
        Goods product = new Goods("книга", DateTime.Now, 100, 10, "123456");

        product.ChangePrice(100);
        product.IncreaseQuantity(5);
        product.DecreaseQuantity(3);
        Console.WriteLine(product);
    }
}
