using System.Collections.Generic;

namespace ShoppingCart;

public class ShoppingCart
{
    private Dictionary<string, CartItem> items = new();

    public void AddItem(string product, int amount)
    {
        if (items.ContainsKey(product))
        {
            items[product].Amount += amount;
        }
        else
        {
            items.Add(product, new CartItem(product, amount));
        }
    }

    public int GetAmountFor(string product)
    {
        if (items.ContainsKey(product))
        {
            return items[product].Amount;
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public List<string> GetProducts()
    {
        return new List<string>(items.Keys);
    }
}