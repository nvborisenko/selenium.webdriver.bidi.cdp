namespace System.Text.Json.Serialization;

[AttributeUsage(AttributeTargets.Field)]
internal sealed class JsonStringEnumMemberNameAttribute(string name) : Attribute
{
    public string Name { get; } = name;
}
