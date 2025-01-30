using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

public class MenuService
{
    private List<MenuItem> menuItems = new List<MenuItem>
    {
        new MenuItem { Name = "Mango Smoothie", Price = 4.99m},
        new MenuItem { Name = "Berry Blast", Price = 5.49m }
    };

    public List<MenuItem> GetMenuItems() => menuItems;

    public void AddMenuItem(MenuItem item)
    {
        menuItems.Add(item);
    }

    public void RemoveMenuItem(MenuItem item)
    {
        menuItems.Remove(item);
    }

}

public class MenuItem
{
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
}