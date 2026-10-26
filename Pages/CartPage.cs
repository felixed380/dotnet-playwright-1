using Microsoft.Playwright;

namespace NPW.Pages;

public class CartPage
{
    private readonly IPage _page;
    public ILocator ItemName => _page.Locator(".inventory_item_name").First;

    private readonly ILocator _checkoutBtn;

    public CartPage(IPage page)
    {
        _page = page;

        _checkoutBtn = page.Locator("#checkout");
    }

    public async Task IrAlCheckout() => await _checkoutBtn.ClickAsync();
}