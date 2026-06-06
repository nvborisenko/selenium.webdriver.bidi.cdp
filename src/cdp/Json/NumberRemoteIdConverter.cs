using System.Text.Json;
using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Json;

internal class NumberRemoteIdConverter<T> : JsonConverter<T> where T : INumberRemoteId, new()
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var id = reader.GetDouble();

        T t = new() { Id = id! };

        return t;
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteNumberValue(value.Id);
    }
}
