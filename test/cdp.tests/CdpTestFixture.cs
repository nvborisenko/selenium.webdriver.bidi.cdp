using OpenQA.Selenium.BiDi;
using OpenQA.Selenium.Chrome;

namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public abstract class CdpTestFixture
{
    protected ChromeDriver Driver { get; private set; } = null!;
    protected IBiDi BiDi { get; private set; } = null!;
    protected OpenQA.Selenium.BiDi.BrowsingContext.BrowsingContext Context { get; private set; } = null!;
    protected CdpModule Cdp { get; private set; } = null!;

    [Before(Test)]
    public async Task SetUp()
    {
        var options = new ChromeOptions { UseWebSocketUrl = true };
        options.AddArgument("--headless=new");
        options.AddArgument("--no-sandbox");
        options.AddArgument("--disable-gpu");
        options.AddArgument("--disable-dev-shm-usage");

        Driver = new ChromeDriver(options);
        BiDi = await Driver.AsBiDiAsync();
        Context = (await BiDi.BrowsingContext.GetTreeAsync()).Contexts[0].Context;
        Cdp = await Context.AsCdpAsync();
    }

    [After(Test)]
    public async Task TearDown()
    {
        await BiDi.DisposeAsync();
        await Driver.DisposeAsync();
    }

    protected async Task NavigateAndWaitForLoadAsync(string url, TimeSpan? timeout = null)
    {
        await Cdp.Page.EnableAsync();

        await using var loadStream = await Cdp.Page.LoadEventFired.StreamAsync();

        await Cdp.Page.NavigateAsync(url);

        await loadStream.ReadAllAsync().FirstAsync().AsTask().WaitAsync(timeout ?? TimeSpan.FromSeconds(30));
    }
}
