using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;

internal record PropertyInfo(string Name)
{
    [JsonInclude]
    public string? Description { get; internal set; }

    [JsonInclude]
    public string? Type { get; internal set; }

    [JsonInclude]
    public bool? Optional { get; internal set; }

    [JsonInclude, JsonPropertyName("$ref")]
    public string? Ref { get; internal set; }

    [JsonInclude]
    public PropertyInfoItem? Items { get; internal set; }

    [JsonInclude]
    public bool? Deprecated { get; internal set; }
}

internal record PropertyInfoItem()
{
    [JsonInclude]
    public string? Type { get; internal set; }

    [JsonInclude, JsonPropertyName("$ref")]
    public string? Ref { get; internal set; }
};