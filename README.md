<table width="100%">
  <tr>
    <td valign="middle" align="left" width="140">
      <img src="docs/images/cdp-logo.svg" alt="CDP over BiDi logo" width="128" height="128" />
    </td>
    <td valign="top" align="left">
      <h1 align="middle">CDP over BiDi</h1>
      <strong>Strongly-typed access to the <a href="https://chromedevtools.github.io/devtools-protocol/">Chrome DevTools Protocol</a> for .NET, over the <a href="https://w3c.github.io/webdriver-bidi/">WebDriver BiDi</a> transport, extending <a href="https://www.selenium.dev/">Selenium WebDriver</a>.</strong>
    </td>
  </tr>
</table>

<p align="right">
  <a href="https://www.nuget.org/packages/Selenium.WebDriver.BiDi.Cdp/"><img src="https://img.shields.io/nuget/v/Selenium.WebDriver.BiDi.Cdp.svg?color=512BD4" alt="NuGet" /></a>
  <a href="https://www.nuget.org/packages/Selenium.WebDriver.BiDi.Cdp/"><img src="https://img.shields.io/nuget/dt/Selenium.WebDriver.BiDi.Cdp.svg?color=512BD4" alt="NuGet Downloads" /></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/license-MIT-blue.svg?color=512BD4" alt="License: MIT" /></a>
</p>

## Features

- **50+ CDP domains** — Page, Network, DOM, Runtime, Debugger, Console, and more
- **Fully async** — async/await with `CancellationToken` support throughout
- **Strongly typed** — auto-generated records for all commands, parameters, and results
- **Spec evolution aware** — always up to date with [CDP API](https://github.com/ChromeDevTools/devtools-protocol) changes, using `Obsolete` and `Experimental` attributes to reflect evolution over time
- **AOT and trimming compatible** — supports Native AOT compilation and IL trimming on .NET 8+

## Installation

```shell
dotnet add package Selenium.WebDriver.BiDi.Cdp
```

## Quick Start

```csharp
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium.WebDriver.BiDi.Cdp;

await using var driver = new ChromeDriver(new ChromeOptions { UseWebSocketUrl = true });
await using var bidi = await driver.AsBiDiAsync();

var tab = (await bidi.BrowsingContext.GetTreeAsync()).Contexts[0].Context;


var cdp = await tab.AsCdpAsync();  // 👈 Your entry point

var result = await cdp.Page.CaptureScreenshotAsync();
Console.WriteLine($"Screenshot data length: {result.Data.Length}");
```

Full API and usage documentation is available at https://nvborisenko.github.io/selenium.webdriver.bidi.cdp

## Building

```shell
dotnet build
```

Force-regenerate the protocol domain classes from the CDP spec:

```shell
dotnet build /p:ForceGenerate=true
```

## License

This project is licensed under the MIT License.

See [LICENSE](LICENSE) for the full license text.
