using System.Text.Json;
using Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;

namespace Selenium.WebDriver.BiDi.Cdp.Generator;

internal static class Parser
{
    public static BrowserProtocol ParseBrowserProtocol(string content)
    {
        var opts = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            RespectRequiredConstructorParameters = true,
            RespectNullableAnnotations = true,
        };

        return JsonSerializer.Deserialize<BrowserProtocol>(content, opts)!;
    }
}
