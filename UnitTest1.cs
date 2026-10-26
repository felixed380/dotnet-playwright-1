using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using System.Text.RegularExpressions;
using NPW.Pages; // Importamos nuestra carpeta de páginas

namespace NPW;

public class LoginTests : PageTest
{
    [Test]
    public async Task LoginExitoso()
    {
        // 1. Instanciamos el Page Object
        var loginPage = new LoginPage(Page);

        // 2. Usamos sus métodos (ya no vemos selectores aquí)
        await loginPage.IrALogin();
        await loginPage.Login("standard_user", "secret_sauce");

        // 3. Validamos el resultado
        await Expect(Page).ToHaveURLAsync(new Regex("inventory"));
    }

    [Test]
    public async Task LoginFallido_UsuarioBloqueado()
    {
        var loginPage = new LoginPage(Page);
        await loginPage.IrALogin();
        await loginPage.Login("locked_out_user", "secret_sauce");

        var erroMsg = Page.Locator("h3[data-test='error']");
        await Expect(errorMsg).ToBeVisibleAsync();
        await Expect(erroMsg).ToContainTextAsync("Sorry, this user has been locked out. ");
    }

    [Test]
    public async Task FlujoCompra_AgregarMochilaAlCarrito()
    {
        var loginPage = new LoginPage(Page);
        var inventoryPage = new InventoryPage(Page);
        var CartPage = new CartPage(Page);

        await loginPage.IrAlLogin();
        await loginPage.Login("standard_user", "secret_sauce");

        await inventoryPage.AgregarMochilaAlCarrito();
        await inventoryPage.IrAlCarrito();

        await Expect(CartPage.ItemName).ToHaveTextAsync("Sauce Labs Backpack")
    }
}
