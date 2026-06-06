using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;

internal record EventInfo(string Name)
{
    [JsonInclude]
    public string? Description { get; internal set; }

    [JsonInclude]
    public bool? Experimental { get; internal set; }

    [JsonInclude]
    public bool? Deprecated { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<ParameterInfo>? Parameters { get; internal set; }
}
