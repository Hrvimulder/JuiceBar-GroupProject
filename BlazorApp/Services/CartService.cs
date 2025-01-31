using System.Collections.Generic;

public class CartService
{
    private List<MenuItem> cartItems = new List<MenuItem>();

    public List<MenuItem> GetCartItems() => cartItems;

    public void AddToCart(MenuItem item)
    {
        cartItems.Add(item);
    }

    public void RemoveFromCart(MenuItem item)
    {
        cartItems.Remove(item);
    }

    public void ClearCart()
    {
        cartItems.Clear();
    }
}
