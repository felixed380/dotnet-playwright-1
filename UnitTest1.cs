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
}