Strongly-typed access to the [Chrome DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) (CDP) for .NET, over the [WebDriver BiDi](https://w3c.github.io/webdriver-bidi/) transport, extending [Selenium WebDriver](https://www.selenium.dev/).

## Quick Start

```csharp
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.WebDriver.BiDi.Cdp;

await using var driver = new ChromeDriver(new ChromeOptions { UseWebSocketUrl = true });
await using var bidi = await driver.AsBiDiAsync();

var tab = (await bidi.BrowsingContext.GetTreeAsync()).Contexts[0].Context;
var cdp = await tab.AsCdpAsync();

var result = await cdp.Page.CaptureScreenshotAsync();
```

See the [docs](https://nvborisenko.github.io/selenium.webdriver.bidi.cdp) for full documentation.
