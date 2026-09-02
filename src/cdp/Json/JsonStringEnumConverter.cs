using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Json;

internal class JsonStringEnumConverter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum>
    : JsonConverter<TEnum> where TEnum : struct, Enum
{
    private static readonly Dictionary<string, TEnum> s_readMap;
    private static readonly Dictionary<TEnum, string> s_writeMap;

    static JsonStringEnumConverter()
    {
#if NETSTANDARD2_0
        var names = Enum.GetNames(typeof(TEnum));
        var values = (TEnum[])Enum.GetValues(typeof(TEnum));
#else
        var names = Enum.GetNames<TEnum>();
        var values = Enum.GetValues<TEnum>();
#endif

        s_readMap = new Dictionary<string, TEnum>(names.Length, StringComparer.Ordinal);
        s_writeMap = new Dictionary<TEnum, string>(names.Length);

        Dictionary<string, string>? attributeNames = null;
        foreach (var field in typeof(TEnum).GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            if (field.GetCustomAttribute<JsonStringEnumMemberNameAttribute>() is { } attr)
            {
                (attributeNames ??= new(StringComparer.Ordinal))[field.Name] = attr.Name;
            }
        }

        for (var i = 0; i < names.Length; i++)
        {
            var name = attributeNames is not null && attributeNames.TryGetValue(names[i], out var attrName)
                ? attrName
                : names[i];

            s_readMap[name] = values[i];
            s_writeMap[values[i]] = name;
        }
    }

    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();

        if (str is not null && s_readMap.TryGetValue(str, out var value))
        {
            return value;
        }

        throw new JsonException($"Unknown {typeof(TEnum).Name} value: {str}");
    }

    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
    {
        if (s_writeMap.TryGetValue(value, out var str))
        {
            writer.WriteStringValue(str);
        }
        else
        {
            throw new JsonException($"Unknown {typeof(TEnum).Name} value: {value}");
        }
    }
}
