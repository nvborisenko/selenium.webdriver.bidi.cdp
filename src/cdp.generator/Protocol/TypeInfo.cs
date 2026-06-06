using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;

internal record TypeInfo(string Id, string Type)
{
    [JsonInclude]
    public string? Description { get; internal set; }

    [JsonInclude]
    public bool? Deprecated { get; internal set; }

    [JsonInclude, JsonPropertyName("$ref")]
    public string? Ref { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<string>? Enum { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<PropertyInfo>? Properties { get; internal set; }

    [JsonInclude]
    public PropertyInfoItem? Items { get; internal set; }

    public string GetTypeName()
    {
        return Id;
    }

    public bool IsNumber()
    {
        return Type is "number" or "integer";
    }

    public bool IsString()
    {
        return Type == "string" && Enum is null;
    }

    public bool IsEnum()
    {
        return Type == "string" && Enum is not null;
    }

    public bool IsDictionary()
    {
        return Type == "object" && Properties is null;
    }

    public bool IsArray()
    {
        return Type == "array";
    }
}
