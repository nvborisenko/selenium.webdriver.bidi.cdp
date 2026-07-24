namespace Selenium.WebDriver.BiDi.Cdp.Tests;

public class PageTests : CdpTestFixture
{
    [Test]
    public async Task PrintToPdf()
    {
        await NavigateAndWaitForLoadAsync("https://www.example.com");

        var result = await Cdp.Page.PrintToPDFAsync(
            landscape: false,
            printBackground: true,
            scale: 1.0,
            paperWidth: 8.5,
            paperHeight: 11,
            marginTop: 0.4,
            marginBottom: 0.4,
            marginLeft: 0.4,
            marginRight: 0.4);

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

        var result = await Cdp.Page.PrintToPDFAsync(
            displayHeaderFooter: true,
            headerTemplate: "<div style='font-size:10px; text-align:center; width:100%'>Custom Header</div>",
            footerTemplate: "<div style='font-size:10px; text-align:center; width:100%'>Page <span class='pageNumber'></span> of <span class='totalPages'></span></div>");

        await Assert.That(result.Data).IsNotNull();
        var pdfBytes = Convert.FromBase64String(result.Data);
        await Assert.That(pdfBytes.Length).IsGreaterThan(0);
    }

    [Test]
    public async Task CaptureScreenshotWithClip()
    {
        await NavigateAndWaitForLoadAsync("https://www.example.com");

        var result = await Cdp.Page.CaptureScreenshotAsync(
            format: "png",
            clip: new Page.Viewport(0, 0, 800, 600, 1));

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
        await NavigateAndWaitForLoadAsync("https://www.example.com");

        var result = await Cdp.Page.CaptureScreenshotAsync(
            format: "jpeg",
            quality: 80);

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
        await NavigateAndWaitForLoadAsync("https://www.selenium.dev");

        // Get full page dimensions
        var metrics = await Cdp.Runtime.EvaluateAsync(
            "JSON.stringify({ width: document.documentElement.scrollWidth, height: document.documentElement.scrollHeight })",
            returnByValue: true);

        var dimensions = System.Text.Json.JsonDocument.Parse(metrics.Result.Value?.ToString()!).RootElement;
        var width = dimensions.GetProperty("width").GetDouble();
        var height = dimensions.GetProperty("height").GetDouble();

        var result = await Cdp.Page.CaptureScreenshotAsync(
            format: "png",
            clip: new Page.Viewport(0, 0, width, height, 1),
            captureBeyondViewport: true);

        await Assert.That(result.Data).IsNotNull();
        var imageBytes = Convert.FromBase64String(result.Data);
        await Assert.That(imageBytes.Length).IsGreaterThan(0);
    }
}
