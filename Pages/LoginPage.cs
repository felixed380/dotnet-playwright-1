using Microsoft.Playwright;

namespace NPW.Pages;

public class LoginPage
{
    private readonly IPage _page;

    // Locators (selectores)
    private readonly ILocator _usernameInput;
    private readonly ILocator _passwordInput;
    private readonly ILocator _loginButton;

    public LoginPage(IPage page)
    {
        _page = page;
        _usernameInput = page.Locator("#user-name");
        _passwordInput = page.Locator("#password");
        _loginButton = page.Locator("#login-button");
    }

    // Acciones
    public async Task IrALogin() => await _page.GotoAsync("https://www.saucedemo.com");

    public async Task Login(string user, string pass)
    {
        await _usernameInput.FillAsync(user);
        await _passwordInput.FillAsync(pass);
        await _loginButton.ClickAsync();
    }
}