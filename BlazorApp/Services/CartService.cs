using System.Collections.Generic;

public class CartService
{
    private List<MenuItem> cartItems = new List<MenuItem>();
    public event Action? OnCartChanged;

    public List<MenuItem> GetCartItems() => cartItems;

    public void AddToCart(MenuItem item)
    {
        cartItems.Add(item);
        NotifyCartChanged();
    }

    public void RemoveFromCart(MenuItem item)
    {
        cartItems.Remove(item);
        NotifyCartChanged();
    }

    public void ClearCart()
    {
        cartItems.Clear();
        NotifyCartChanged();
    }

    private void NotifyCartChanged()
    {
        OnCartChanged?.Invoke();
    }
}
