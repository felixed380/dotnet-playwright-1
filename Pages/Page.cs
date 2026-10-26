using Microsoft.Playwright;

namespace NPW.Pages;

public class InventoryPage
{
    private readonly IPage _page;
    private readonly ILocator _addToCartBtn;
    private readonly ILocator _cartIcon;

    public InventoryPage(IPage page)
    {
        _page = page;
        _addToCartBtn = page.Locator("button[data-test='add-to-cart-sauce-labs-backpack']");
        _carIcon = page.Locator(".shopping_cart_link");
    }

    public async Task AgregarMochilaCarrito() => await _addToCartBtn.ClickAsync();
    public async Task IrAlCarrito() => await _cartIcon.ClickAsync();

}