namespace ShoppingCart;

public class CartItem
{
    public string Product { get; set; }
    public int Amount { get; set; }

    public CartItem(string product, int amount)
    {
        Product = product;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"{Amount} x {Product}";
    }
}