---
title: Getting Started
description: Install Selenium.WebDriver.BiDi.Cdp, connect to Chrome over WebDriver BiDi, and run your first Chrome DevTools Protocol (CDP) command in .NET.
---

# Getting Started

## Install

```shell
dotnet add package Selenium.WebDriver.BiDi.Cdp
```

## Connect and run a command

Enable the WebSocket URL on `ChromeOptions`, obtain a BiDi session, then get a
CDP entry point for a browsing context (tab):

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

## Next steps

- Browse the [API reference](../api/index.md) for every supported CDP domain.
- Read the [Introduction](introduction.md) for background on how CDP is
  tunnelled over WebDriver BiDi.