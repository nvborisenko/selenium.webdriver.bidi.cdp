using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Selenium.WebDriver.BiDi.Cdp.Json;

internal class JsonStringEnumConverter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicFields)] TEnum>
    : JsonConverter<TEnum> where TEnum : struct, Enum
{
    // Read matches against UTF-8 names so that no string is allocated per value. CDP enums are
    // small enough that a linear scan beats hashing a decoded string.
    private static readonly (byte[] Utf8Name, TEnum Value)[] s_readMap;
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

        s_readMap = new (byte[], TEnum)[names.Length];
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

            s_readMap[i] = (Encoding.UTF8.GetBytes(name), values[i]);
            s_writeMap[values[i]] = name;
        }
    }

    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var readMap = s_readMap;

        for (var i = 0; i < readMap.Length; i++)
        {
            if (reader.ValueTextEquals(readMap[i].Utf8Name))
            {
                return readMap[i].Value;
            }
        }

        throw new JsonException($"Unknown {typeof(TEnum).Name} value: {reader.GetString()}");
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
