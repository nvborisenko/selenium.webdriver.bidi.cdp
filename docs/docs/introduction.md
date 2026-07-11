---
title: Introduction
description: An overview of Selenium.WebDriver.BiDi.Cdp — a .NET library exposing the Chrome DevTools Protocol (CDP) over the WebDriver BiDi transport for Selenium WebDriver.
---

# Introduction

**Selenium.WebDriver.BiDi.Cdp** brings the [Chrome DevTools Protocol](https://chromedevtools.github.io/devtools-protocol/)
(CDP) to .NET on top of the [WebDriver BiDi](https://w3c.github.io/webdriver-bidi/)
transport, so you can drive low-level browser capabilities directly from
[Selenium WebDriver](https://www.selenium.dev/).

## Why it exists

Classic CDP access relied on a separate DevTools connection that was tied to a
specific Chrome version. By tunnelling CDP over WebDriver BiDi, this library
reuses the existing WebDriver session — no extra endpoints, no version-pinned
DevTools clients.

## What you get

- Strongly-typed, auto-generated bindings for **50+ CDP domains** such as
  `Page`, `Network`, `DOM`, `Runtime`, `Debugger`, and `Console`.
- A fully `async` API with `CancellationToken` support.
- Native AOT and IL trimming compatibility on .NET 8+.
- Fast, source-generated `System.Text.Json` serialization.

Continue to [Getting Started](getting-started.md) to install the package and run
your first command.