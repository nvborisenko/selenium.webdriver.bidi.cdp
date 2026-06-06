# Selenium.WebDriver.BiDi.Cdp

A .NET library that provides strongly-typed access to the [Chrome DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/) (CDP) over the [WebDriver BiDi](https://w3c.github.io/webdriver-bidi/) transport, extending [Selenium WebDriver](https://www.selenium.dev/).

## Features

- **50+ CDP domains** — Page, Network, DOM, Runtime, Debugger, Console, and more
- **Fully async** — async/await with `CancellationToken` support throughout
- **Strongly typed** — auto-generated records for all commands, parameters, and results
- **AOT and trimming compatible** — supports Native AOT compilation and IL trimming on .NET 8+
- **Source-generated JSON** — uses `System.Text.Json` source generators for fast, allocation-free serialization

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

// Your entry point
var cdp = await tab.AsCdpAsync();

// Capture a screenshot
var result = await cdp.Page.CaptureScreenshotAsync();
Console.WriteLine($"Screenshot data length: {result.Data.Length}");
```

## Building

```shell
dotnet build
```

Force-regenerate the protocol domain classes from the CDP spec:

```shell
dotnet build /p:ForceGenerate=true
```

## License

[MIT](LICENSE)
