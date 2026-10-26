using Microsoft.Playwright;

namespace NPW.Pages;

public class CartPage
{
    private readonly IPage _page;
    public ILocator ItemName => _page.Locator(".inventory_item_name");
    public CartPage(IPage page)
    {
        _page = page;
    }

}