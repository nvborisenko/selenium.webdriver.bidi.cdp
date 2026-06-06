using System.Text.Json;
using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Json;

internal class StringRemoteIdConverter<T> : JsonConverter<T> where T : IStringRemoteId, new()
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var id = reader.GetString();

        T t = new() { Id = id! };

        return t;
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Id);
    }
}
