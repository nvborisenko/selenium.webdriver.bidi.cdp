using BenchmarkDotNet.Running;
using Selenium.WebDriver.BiDi.Cdp.Benchmark;

BenchmarkRunner.Run<EvaluateBenchmark>();
BenchmarkRunner.Run<CaptureScreenshotBenchmark>();
