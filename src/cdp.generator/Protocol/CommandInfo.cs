using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;

internal record CommandInfo(string Name)
{
    [JsonInclude]
    public string? Description { get; internal set; }

    [JsonInclude]
    public bool? Experimental { get; internal set; }

    [JsonInclude]
    public bool? Deprecated { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<ParameterInfo>? Parameters { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<ReturnInfo>? Returns { get; internal set; }
}

internal record ParameterInfo(string Name)
{
    [JsonInclude]
    public string? Description { get; internal set; }

    [JsonInclude]
    public bool? Optional { get; internal set; }

    [JsonInclude]
    public string? Type { get; internal set; }

    [JsonInclude, JsonPropertyName("$ref")]
    public string? Ref { get; internal set; }

    [JsonInclude]
    public ParameterInfoItem? Items { get; internal set; }

    [JsonInclude]
    public bool? Deprecated { get; internal set; }
}

internal record ParameterInfoItem()
{
    [JsonInclude]
    public string? Type { get; internal set; }

    [JsonInclude, JsonPropertyName("$ref")]
    public string? Ref { get; internal set; }
};

internal record ReturnInfo(string Name)
{
    [JsonInclude]
    public string? Description { get; internal set; }

    [JsonInclude]
    public string? Type { get; internal set; }

    [JsonInclude, JsonPropertyName("$ref")]
    public string? Ref { get; internal set; }

    [JsonInclude]
    public bool? Optional { get; internal set; }

    [JsonInclude]
    public ReturnInfoItem? Items { get; internal set; }
}

internal record ReturnInfoItem()
{
    [JsonInclude]
    public string? Type { get; internal set; }

    [JsonInclude, JsonPropertyName("$ref")]
    public string? Ref { get; internal set; }
};
