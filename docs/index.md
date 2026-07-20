---
_layout: landing
title: CDP over WebDriver BiDi for .NET
description: Selenium.WebDriver.BiDi.Cdp is a .NET library providing strongly-typed, fully async access to the Chrome DevTools Protocol (CDP) over the WebDriver BiDi transport, extending Selenium WebDriver.
---

# CDP over WebDriver BiDi

**Selenium.WebDriver.BiDi.Cdp** is a .NET library that provides strongly-typed
access to the [Chrome DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/)
(CDP) over the [WebDriver BiDi](https://w3c.github.io/webdriver-bidi/) transport,
extending [Selenium WebDriver](https://www.selenium.dev/).

## Features

- **50+ CDP domains** — Page, Network, DOM, Runtime, Debugger, Console, and more.
- **Fully async** — `async`/`await` with `CancellationToken` support throughout.
- **Strongly typed** — auto-generated records for all commands, parameters, and results.
- **AOT and trimming compatible** — supports Native AOT compilation and IL trimming on .NET 8+.
- **Source-generated JSON** — uses `System.Text.Json` source generators for fast, allocation-free serialization.

## Installation

```shell
dotnet add package Selenium.WebDriver.BiDi.Cdp
```

## Quick start

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

## Learn more

- [Introduction](docs/introduction.md) — what the library is and why it exists.
- [Getting started](docs/getting-started.md) — install, connect, and run your first CDP command.
- [API reference](api/index.md) — full API documentation for all CDP domains.