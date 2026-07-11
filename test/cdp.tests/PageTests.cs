namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class PageTests : CdpTestFixture
{
    [Test]
    public async Task PrintToPdf()
    {
        await NavigateAndWaitForLoadAsync("https://www.example.com");

        var result = await Cdp.Page.PrintToPDFAsync(new()
        {
            Landscape = false,
            PrintBackground = true,
            Scale = 1.0,
            PaperWidth = 8.5,
            PaperHeight = 11,
            MarginTop = 0.4,
            MarginBottom = 0.4,
            MarginLeft = 0.4,
            MarginRight = 0.4
        });

        await Assert.That(result.Data).IsNotNull();

        // Verify it's valid base64-encoded PDF
        var pdfBytes = Convert.FromBase64String(result.Data);
        await Assert.That(pdfBytes.Length).IsGreaterThan(0);

        // PDF files start with %PDF
        var header = System.Text.Encoding.ASCII.GetString(pdfBytes, 0, 4);
        await Assert.That(header).IsEqualTo("%PDF");
    }

    [Test]
    public async Task PrintToPdfWithHeaderAndFooter()
    {
        await NavigateAndWaitForLoadAsync("https://www.example.com");

        var result = await Cdp.Page.PrintToPDFAsync(new()
        {
            DisplayHeaderFooter = true,
            HeaderTemplate = "<div style='font-size:10px; text-align:center; width:100%'>Custom Header</div>",
            FooterTemplate = "<div style='font-size:10px; text-align:center; width:100%'>Page <span class='pageNumber'></span> of <span class='totalPages'></span></div>"
        });

        await Assert.That(result.Data).IsNotNull();
        var pdfBytes = Convert.FromBase64String(result.Data);
        await Assert.That(pdfBytes.Length).IsGreaterThan(0);
    }

    [Test]
    public async Task CaptureScreenshotWithClip()
    {
        await Cdp.Page.NavigateAsync("https://www.example.com");

        var result = await Cdp.Page.CaptureScreenshotAsync(new()
        {
            Format = "png",
            Clip = new Page.Viewport(0, 0, 800, 600, 1)
        });

        await Assert.That(result.Data).IsNotNull();

        var imageBytes = Convert.FromBase64String(result.Data);
        await Assert.That(imageBytes.Length).IsGreaterThan(0);

        // PNG files start with specific magic bytes
        await Assert.That(imageBytes[0]).IsEqualTo((byte)0x89);
        await Assert.That(imageBytes[1]).IsEqualTo((byte)0x50); // 'P'
        await Assert.That(imageBytes[2]).IsEqualTo((byte)0x4E); // 'N'
        await Assert.That(imageBytes[3]).IsEqualTo((byte)0x47); // 'G'
    }

    [Test]
    public async Task CaptureScreenshotAsJpeg()
    {
        await Cdp.Page.NavigateAsync("https://www.example.com");

        var result = await Cdp.Page.CaptureScreenshotAsync(new()
        {
            Format = "jpeg",
            Quality = 80
        });

        await Assert.That(result.Data).IsNotNull();

        var imageBytes = Convert.FromBase64String(result.Data);
        await Assert.That(imageBytes.Length).IsGreaterThan(0);

        // JPEG files start with FF D8
        await Assert.That(imageBytes[0]).IsEqualTo((byte)0xFF);
        await Assert.That(imageBytes[1]).IsEqualTo((byte)0xD8);
    }

    [Test]
    public async Task CaptureFullPageScreenshot()
    {
        await Cdp.Page.NavigateAsync("https://www.selenium.dev");

        // Get full page dimensions
        var metrics = await Cdp.Runtime.EvaluateAsync(
            "JSON.stringify({ width: document.documentElement.scrollWidth, height: document.documentElement.scrollHeight })",
            new() { ReturnByValue = true });

        var dimensions = System.Text.Json.JsonDocument.Parse(metrics.Result.Value?.ToString()!).RootElement;
        var width = dimensions.GetProperty("width").GetDouble();
        var height = dimensions.GetProperty("height").GetDouble();

        var result = await Cdp.Page.CaptureScreenshotAsync(new()
        {
            Format = "png",
            Clip = new Page.Viewport(0, 0, width, height, 1),
            CaptureBeyondViewport = true
        });

        await Assert.That(result.Data).IsNotNull();
        var imageBytes = Convert.FromBase64String(result.Data);
        await Assert.That(imageBytes.Length).IsGreaterThan(0);
    }
}
