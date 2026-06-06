using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;

internal record DomainInfo(string Domain)
{
    [JsonInclude]
    public string? Description { get; internal set; }

    [JsonInclude]
    public bool? Experimental { get; internal set; }

    [JsonInclude]
    public bool? Deprecated { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<TypeInfo>? Types { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<string>? Dependencies { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<CommandInfo>? Commands { get; internal set; }

    [JsonInclude]
    public IReadOnlyList<EventInfo>? Events { get; internal set; }
}
