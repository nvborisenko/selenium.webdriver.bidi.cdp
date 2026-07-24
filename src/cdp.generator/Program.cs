using System.Text;
using System.Text.RegularExpressions;
using Selenium.WebDriver.BiDi.Cdp.Generator;
using Selenium.WebDriver.BiDi.Cdp.Generator.Protocol;
using Humanizer;

const string rootNamespace = "Selenium.WebDriver.BiDi.Cdp";
const string experimentalDiagnosticId = "BIDICDP001";

var outputDirectory = new DirectoryInfo("_gen");

if (outputDirectory.Exists) outputDirectory.Delete(true);

outputDirectory.Create();

var inputFiles = Directory.GetFiles("spec", "*.json")
    .OrderBy(Path.GetFileName, StringComparer.Ordinal)
    .ToArray();

// Collect dictionary types (object without properties) across all protocols
foreach (var inputFile in inputFiles)
{
    var protocol = Parser.ParseBrowserProtocol(File.ReadAllText(inputFile));
    foreach (var domain in protocol.Domains)
    {
        foreach (var type in domain.Types ?? [])
        {
            if (type.IsDictionary())
            {
                Extensions.DictionaryTypes.Add(type.Id);
            }
            else if (type.IsArray())
            {
                Extensions.ArrayTypes.Add(type.Id, type.Items!);
            }
        }
    }
}

foreach (var inputFile in inputFiles)
{
    var browserProtocol = Parser.ParseBrowserProtocol(File.ReadAllText(inputFile));

    foreach (var domainInfo in browserProtocol.Domains)
    {
        var domainBuilder = new StringBuilder();

        domainBuilder.AppendLine("#nullable enable");
        domainBuilder.AppendLine("#pragma warning disable CS0612");
        domainBuilder.AppendLine("using global::System.Text.Json.Serialization;");
        domainBuilder.AppendLine("using global::OpenQA.Selenium.BiDi;");
        domainBuilder.AppendLine();
        domainBuilder.AppendLine($"namespace {rootNamespace}.{domainInfo.Domain};");

        domainBuilder.AppendLine();

        AppendSummary(domainBuilder, domainInfo.Description);
        AppendAvailabilityAttributes(domainBuilder, domainInfo.Experimental is true, domainInfo.Deprecated is true);

        domainBuilder.AppendLine($"public interface I{domainInfo.Domain}");
        domainBuilder.AppendLine("{");

        if (domainInfo.Commands is not null)
        {
            foreach (var commandInfo in domainInfo.Commands)
            {
                AppendCommandDocumentation(domainBuilder, commandInfo, "    ");
                AppendAvailabilityAttributes(
                    domainBuilder,
                    commandInfo.Experimental is true && domainInfo.Experimental is not true,
                    commandInfo.Deprecated is true,
                    "    ");
                domainBuilder.AppendLine($"    Task<{commandInfo.Name.Dehumanize()}Result> {commandInfo.Name.Dehumanize()}Async({GetCommandSignature(commandInfo, includeDefaultValues: true)});");
                domainBuilder.AppendLine();
            }
        }

        if (domainInfo.Events is not null)
        {
            foreach (var eventInfo in domainInfo.Events)
            {
                AppendEventDocumentation(domainBuilder, eventInfo, "    ");
                AppendAvailabilityAttributes(
                    domainBuilder,
                    eventInfo.Experimental is true && domainInfo.Experimental is not true,
                    eventInfo.Deprecated is true,
                    "    ");
                domainBuilder.AppendLine($"    IEventSource<{eventInfo.Name.Dehumanize()}EventArgs> {eventInfo.Name.Dehumanize()} {{ get; }}");
                domainBuilder.AppendLine();
            }
        }

        domainBuilder.AppendLine("}");
        domainBuilder.AppendLine();
    AppendAvailabilityAttributes(domainBuilder, domainInfo.Experimental is true, domainInfo.Deprecated is true);
        domainBuilder.AppendLine($"internal sealed class {domainInfo.Domain}Domain(CdpModule cdp) : global::{rootNamespace}.Domain(cdp), I{domainInfo.Domain}");
        domainBuilder.AppendLine("{");

        // JsonContext alias
        domainBuilder.AppendLine($"    private static {domainInfo.Domain}JsonSerializerContext JsonContext = {domainInfo.Domain}JsonSerializerContext.Default;");
        domainBuilder.AppendLine();

        // Commands
        if (domainInfo.Commands is not null)
        {
            foreach (var commandInfo in domainInfo.Commands)
            {
                var sessionArgName = GetSessionArgumentName(commandInfo);

                AppendAvailabilityAttributes(
                    domainBuilder,
                    commandInfo.Experimental is true && domainInfo.Experimental is not true,
                    commandInfo.Deprecated is true,
                    "    ");

                domainBuilder.AppendLine($"    public async Task<{commandInfo.Name.Dehumanize()}Result> {commandInfo.Name.Dehumanize()}Async({GetCommandSignature(commandInfo, includeDefaultValues: true)})");
                domainBuilder.AppendLine("    {");
                domainBuilder.Append($"        var @params = new {commandInfo.Name.Dehumanize()}CommandParameters(");

                domainBuilder.Append(GetCommandParameterInitializer(commandInfo));

                domainBuilder.AppendLine(");");

                domainBuilder.AppendLine($"        return await ExecuteCommandAsync({commandInfo.Name.Dehumanize()}Command, @params, {sessionArgName}, cancellationToken).ConfigureAwait(false);");
                domainBuilder.AppendLine("    }");

                domainBuilder.AppendLine($"    private static readonly CdpCommand<{commandInfo.Name.Dehumanize()}CommandParameters, {commandInfo.Name.Dehumanize()}Result> {commandInfo.Name.Dehumanize()}Command = new(\"{domainInfo.Domain}.{commandInfo.Name}\", JsonContext.{commandInfo.Name.Dehumanize()}CommandParameters, JsonContext.{commandInfo.Name.Dehumanize()}Result);");
                domainBuilder.AppendLine();
            }
        }

        // Event Accessors
        if (domainInfo.Events is not null)
        {
            foreach (var eventInfo in domainInfo.Events)
            {
                AppendAvailabilityAttributes(
                    domainBuilder,
                    eventInfo.Experimental is true && domainInfo.Experimental is not true,
                    eventInfo.Deprecated is true,
                    "    ");
                domainBuilder.AppendLine($"    public IEventSource<{eventInfo.Name.Dehumanize()}EventArgs> {eventInfo.Name.Dehumanize()} => CreateCdpEventSource({domainInfo.Domain}DomainEvent.{eventInfo.Name.Dehumanize()});");
            }
        }

        domainBuilder.AppendLine("}");

        // Command Types
        if (domainInfo.Commands is not null)
        {
            foreach (var commandInfo in domainInfo.Commands)
            {
                // parameters
                domainBuilder.AppendLine();
                domainBuilder.Append($"internal sealed record {commandInfo.Name.Dehumanize()}CommandParameters(");

                if (commandInfo.Parameters is not null)
                {
                    for (int i = 0; i < commandInfo.Parameters.Count; i++)
                    {
                        var parameterInfo = commandInfo.Parameters[i];

                        domainBuilder.Append($"{parameterInfo.AsCSharpType()} {parameterInfo.Name.Dehumanize()}");

                        if (i != commandInfo.Parameters.Count - 1)
                        {
                            domainBuilder.Append(", ");
                        }
                    }
                }

                domainBuilder.AppendLine(") : Parameters;");
                domainBuilder.AppendLine();

                // result summary
                domainBuilder.AppendLine("/// <summary>");
                domainBuilder.AppendLine("/// </summary>");

                if (commandInfo.Returns is not null)
                {
                    foreach (var returnType in commandInfo.Returns)
                    {
                        domainBuilder.AppendLine($"/// <param name=\"{returnType.Name.Dehumanize()}\">");
                        if (returnType.Description is not null)
                        {
                            foreach (var line in GetNormalizedDescription(returnType.Description))
                            {
                                domainBuilder.AppendLine($"/// {line}");
                            }
                        }
                        domainBuilder.AppendLine("/// </param>");
                    }
                }

                domainBuilder.Append($"public sealed record {commandInfo.Name.Dehumanize()}Result(");

                if (commandInfo.Returns is not null)
                {
                    for (int i = 0; i < commandInfo.Returns.Count; i++)
                    {
                        var returnType = commandInfo.Returns[i];

                        domainBuilder.Append($"{returnType.AsCSharpType()} {returnType.Name.Dehumanize()}");

                        if (i != commandInfo.Returns.Count - 1) // not last yet
                        {
                            domainBuilder.Append(", ");
                        }
                    }
                }

                domainBuilder.AppendLine(") : EmptyResult;");
                domainBuilder.AppendLine();
            }
        }

        // Event Args
        if (domainInfo.Events is not null)
        {
            foreach (var eventInfo in domainInfo.Events)
            {
                domainBuilder.AppendLine();

                domainBuilder.AppendLine("/// <summary>");
                if (eventInfo.Description is not null)
                {
                    foreach (var line in GetNormalizedDescription(eventInfo.Description))
                    {
                        domainBuilder.AppendLine($"/// {line}");
                    }
                }
                domainBuilder.AppendLine("/// </summary>");

                if (eventInfo.Parameters is { Count: > 0 })
                {
                    var allParams = eventInfo.Parameters;

                    foreach (var parameterInfo in allParams)
                    {
                        domainBuilder.AppendLine($"/// <param name=\"{parameterInfo.Name.Dehumanize()}\">");
                        if (parameterInfo.Description is not null)
                        {
                            foreach (var line in GetNormalizedDescription(parameterInfo.Description))
                            {
                                domainBuilder.AppendLine($"/// {line}");
                            }
                        }
                        domainBuilder.AppendLine("/// </param>");
                    }

                    domainBuilder.Append($"public sealed record {eventInfo.Name.Dehumanize()}EventArgs(");

                    for (int i = 0; i < allParams.Count; i++)
                    {
                        var parameterInfo = allParams[i];
                        var type = parameterInfo.Optional is true
                            ? parameterInfo.AsCSharpType().TrimEnd('?') + "?"
                            : parameterInfo.AsCSharpType();
                        var defaultValue = parameterInfo.Optional is true ? " = null" : "";
                        domainBuilder.Append($"{type} {parameterInfo.Name.Dehumanize()}{defaultValue}");
                        if (i != allParams.Count - 1) domainBuilder.Append(", ");
                    }

                    domainBuilder.AppendLine(") : OpenQA.Selenium.BiDi.EventArgs;");
                }
                else
                {
                    domainBuilder.AppendLine($"public sealed record {eventInfo.Name.Dehumanize()}EventArgs() : OpenQA.Selenium.BiDi.EventArgs;");
                }
            }
        }

        // Nested Types
        if (domainInfo.Types is not null)
        {
            foreach (var typeInfo in domainInfo.Types)
            {
                domainBuilder.AppendLine();

                domainBuilder.AppendLine("/// <summary>");
                if (typeInfo.Description is not null)
                {
                    foreach (var line in GetNormalizedDescription(typeInfo.Description))
                    {
                        domainBuilder.AppendLine($"/// {line}");
                    }
                }
                domainBuilder.AppendLine("/// </summary>");

                if (typeInfo.Properties is not null)
                {
                    var requiredProperties = typeInfo.Properties.Where(p => p.Optional is not true).ToList();

                    foreach (var propertyInfo in requiredProperties)
                    {
                        domainBuilder.AppendLine($"/// <param name=\"{propertyInfo.Name.Dehumanize()}\">");
                        if (propertyInfo.Description is not null)
                        {
                            foreach (var line in GetNormalizedDescription(propertyInfo.Description))
                            {
                                domainBuilder.AppendLine($"/// {line}");
                            }
                        }
                        domainBuilder.AppendLine("/// </param>");
                    }
                }

                if (typeInfo.IsEnum())
                {
                    var enumTypeName = typeInfo.GetTypeName();

                    if (typeInfo.Deprecated is true)
                    {
                        domainBuilder.AppendLine("[global::System.Obsolete]");
                    }

                    domainBuilder.AppendLine($"[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<{enumTypeName}>))]");
                    domainBuilder.AppendLine($"public enum {enumTypeName}");
                    domainBuilder.AppendLine("{");

                    foreach (var enumValue in typeInfo.Enum!)
                    {
                        domainBuilder.AppendLine("    /// <summary>");
                        domainBuilder.AppendLine("    /// </summary>");
                        domainBuilder.AppendLine($"    [global::System.Text.Json.Serialization.JsonStringEnumMemberName(\"{enumValue}\")]");
                        domainBuilder.AppendLine($"    {enumValue.Dehumanize()},");
                    }

                    domainBuilder.AppendLine("}");
                }
                else if (typeInfo.IsNumber())
                {
                    if (typeInfo.Deprecated is true)
                    {
                        domainBuilder.AppendLine("[global::System.Obsolete]");
                    }

                    domainBuilder.AppendLine($"[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.NumberRemoteIdConverter<{typeInfo.GetTypeName()}>))]");
                    domainBuilder.AppendLine($"public record {typeInfo.GetTypeName()} : INumberRemoteId");
                    domainBuilder.AppendLine("{");
                    domainBuilder.AppendLine("    double INumberRemoteId.Id { get; init; }");
                    domainBuilder.AppendLine("}");
                }
                else if (typeInfo.IsString())
                {
                    if (typeInfo.Deprecated is true)
                    {
                        domainBuilder.AppendLine("[global::System.Obsolete]");
                    }

                    domainBuilder.AppendLine($"[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.StringRemoteIdConverter<{typeInfo.GetTypeName()}>))]");
                    domainBuilder.AppendLine($"public record {typeInfo.GetTypeName()} : IStringRemoteId");
                    domainBuilder.AppendLine("{");
                    domainBuilder.AppendLine("    string IStringRemoteId.Id { get; init; } = null!;");
                    domainBuilder.AppendLine("}");
                }
                else if (typeInfo.IsDictionary())
                {
                    // Skip generation — resolved as JsonObject at usage sites
                }
                else if (typeInfo.IsArray())
                {
                    // Skip generation — resolved as ImmutableArray<T> at usage sites
                }
                else
                {
                    if (typeInfo.Deprecated is true)
                    {
                        domainBuilder.AppendLine("[global::System.Obsolete]");
                    }

                    domainBuilder.Append($"public sealed record {typeInfo.GetTypeName()}(");

                    if (typeInfo.Properties is not null)
                    {
                        var requiredProperties = typeInfo.Properties.Where(p => p.Optional is not true).ToList();

                        for (int i = 0; i < requiredProperties.Count; i++)
                        {
                            var propertyInfo = requiredProperties[i];

                            domainBuilder.Append($"{propertyInfo.AsCSharpType()} {propertyInfo.Name.Dehumanize()}");

                            if (i != requiredProperties.Count - 1)
                            {
                                domainBuilder.Append(", ");
                            }
                        }
                    }

                    domainBuilder.AppendLine(")");
                    domainBuilder.AppendLine("{");

                    if (typeInfo.Properties is not null)
                    {
                        var optionalProperties = typeInfo.Properties.Where(p => p.Optional is true).ToList();

                        for (int i = 0; i < optionalProperties.Count; i++)
                        {
                            var propertyInfo = optionalProperties[i];

                            domainBuilder.AppendLine("    /// <summary>");
                            if (propertyInfo.Description is not null)
                            {
                                foreach (var line in GetNormalizedDescription(propertyInfo.Description))
                                {
                                    domainBuilder.AppendLine($"    /// {line}");
                                }
                            }
                            domainBuilder.AppendLine("    /// </summary>");

                            if (propertyInfo.Deprecated is true)
                            {
                                domainBuilder.AppendLine("    [global::System.Obsolete]");
                            }

                            domainBuilder.AppendLine($"    public {propertyInfo.AsCSharpType()} {propertyInfo.Name.Dehumanize()} {{ get; init; }}");

                            if (i != optionalProperties.Count - 1)
                            {
                                domainBuilder.AppendLine();
                            }
                        }
                    }

                    domainBuilder.AppendLine("}");
                }
            }
        }

        // Json Context
        domainBuilder.AppendLine();

        if (domainInfo.Commands is not null)
        {
            foreach (var commandInfo in domainInfo.Commands)
            {
                domainBuilder.AppendLine($"[JsonSerializable(typeof({commandInfo.Name.Dehumanize()}CommandParameters), TypeInfoPropertyName = \"{commandInfo.Name.Dehumanize()}CommandParameters\")]");
                domainBuilder.AppendLine($"[JsonSerializable(typeof({commandInfo.Name.Dehumanize()}Result), TypeInfoPropertyName = \"{commandInfo.Name.Dehumanize()}Result\")]");
            }
        }

        if (domainInfo.Events is not null)
        {
            foreach (var eventInfo in domainInfo.Events)
            {
                domainBuilder.AppendLine($"[JsonSerializable(typeof(CdpEventArgs<{eventInfo.Name.Dehumanize()}EventArgs>), TypeInfoPropertyName = \"{eventInfo.Name.Dehumanize()}CdpEventArgs\")]");
            }
        }

        if (domainInfo.Types is not null)
        {
            foreach (var typeInfo in domainInfo.Types)
            {
                if (typeInfo.IsDictionary()) continue;
                if (typeInfo.IsArray()) continue;

                domainBuilder.AppendLine($"[JsonSerializable(typeof({typeInfo.GetTypeName()}), TypeInfoPropertyName = \"{domainInfo.Domain}{typeInfo.GetTypeName()}\")]");
            }
        }

        // Register collection types to avoid SYSLIB1031 collisions on generic type names
        var collectionTypes = new HashSet<string>();

        void CollectArrayRef(string? type, string? itemRef)
        {
            if (type == "array" && itemRef is not null)
            {
                var typeName = itemRef.Contains('.') ? itemRef.Split('.')[1] : itemRef;
                if (!Extensions.DictionaryTypes.Contains(typeName) && !Extensions.ArrayTypes.ContainsKey(typeName))
                {
                    collectionTypes.Add(itemRef);
                }
            }
        }

        if (domainInfo.Commands is not null)
        {
            foreach (var commandInfo in domainInfo.Commands)
            {
                foreach (var p in commandInfo.Parameters ?? [])
                    CollectArrayRef(p.Type, p.Items?.Ref);
                foreach (var r in commandInfo.Returns ?? [])
                    CollectArrayRef(r.Type, r.Items?.Ref);
            }
        }

        if (domainInfo.Events is not null)
        {
            foreach (var eventInfo in domainInfo.Events)
            {
                foreach (var p in eventInfo.Parameters ?? [])
                    CollectArrayRef(p.Type, p.Items?.Ref);
            }
        }

        if (domainInfo.Types is not null)
        {
            foreach (var typeInfo in domainInfo.Types)
            {
                foreach (var p in typeInfo.Properties ?? [])
                    CollectArrayRef(p.Type, p.Items?.Ref);
            }
        }

        foreach (var elementType in collectionTypes)
        {
            var qualifiedName = elementType.Contains('.') ? elementType.Replace(".", "") : $"{domainInfo.Domain}{elementType}";
            domainBuilder.AppendLine($"[JsonSerializable(typeof(ImmutableArray<{elementType}>), TypeInfoPropertyName = \"ImmutableArray{qualifiedName}\")]");
        }

        domainBuilder.AppendLine($"""
        [JsonSourceGenerationOptions(
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
        partial class {domainInfo.Domain}JsonSerializerContext : JsonSerializerContext;
        """);

        // Static Events
        domainBuilder.AppendLine();
        if (domainInfo.Events is not null)
        {
            domainBuilder.AppendLine("/// <summary>");
            domainBuilder.AppendLine($"/// Provides static event descriptors for the <see cref=\"I{domainInfo.Domain}\"/>.");
            domainBuilder.AppendLine("/// </summary>");
            domainBuilder.AppendLine($"public static class {domainInfo.Domain}DomainEvent");
            domainBuilder.AppendLine("{");

            foreach (var eventInfo in domainInfo.Events)
            {
                domainBuilder.AppendLine("    /// <summary>");
                foreach (var line in GetNormalizedDescription(eventInfo.Description ?? string.Empty))
                {
                    domainBuilder.AppendLine($"    /// {line}");
                }
                domainBuilder.AppendLine("    /// </summary>");

                domainBuilder.AppendLine($"    public static EventDescriptor<CdpEventArgs<{eventInfo.Name.Dehumanize()}EventArgs>> {eventInfo.Name.Dehumanize()} {{ get; }} =");
                domainBuilder.AppendLine($"        EventDescriptor<CdpEventArgs<{eventInfo.Name.Dehumanize()}EventArgs>>.Create(");
                domainBuilder.AppendLine($"            \"goog:cdp.{domainInfo.Domain}.{eventInfo.Name}\",");
                domainBuilder.AppendLine($"            {domainInfo.Domain}JsonSerializerContext.Default.{eventInfo.Name.Dehumanize()}CdpEventArgs);");
                domainBuilder.AppendLine();
            }

            domainBuilder.AppendLine("}");
        }

        File.WriteAllText(Path.Combine(outputDirectory.FullName, $"{domainInfo.Domain}Domain.g.cs"), domainBuilder.ToString());
    }
}


// domain accessors
var cdpModuleBuilder = new StringBuilder();

cdpModuleBuilder.AppendLine("#nullable enable");
cdpModuleBuilder.AppendLine("#pragma warning disable CS0612");
cdpModuleBuilder.AppendLine();
cdpModuleBuilder.AppendLine($"namespace {rootNamespace};");
cdpModuleBuilder.AppendLine();

cdpModuleBuilder.AppendLine("partial class CdpModule");
cdpModuleBuilder.AppendLine("{");
cdpModuleBuilder.AppendLine("#pragma warning disable BIDICDP001");

// Generate fields and properties together
var domainsToGenerate = new List<(string InputFile, DomainInfo Domain)>();
foreach (var inputFile in inputFiles)
{
    var browserProtocol = Parser.ParseBrowserProtocol(File.ReadAllText(inputFile));
    foreach (var domainInfo in browserProtocol.Domains)
    {
        domainsToGenerate.Add((inputFile, domainInfo));
    }
}

// Generate each field-property pair together
foreach (var (inputFile, domainInfo) in domainsToGenerate)
{
    var propertyNameCamelCase = domainInfo.Domain.Substring(0, 1).ToLower() + (domainInfo.Domain.Length > 1 ? domainInfo.Domain.Substring(1) : "");
    
    // Generate the backing field
    cdpModuleBuilder.AppendLine($"    private {domainInfo.Domain}.I{domainInfo.Domain}? _{propertyNameCamelCase};");
    cdpModuleBuilder.AppendLine();
    
    // Generate the property documentation and attribute
    cdpModuleBuilder.AppendLine("    /// <summary>");
    if (domainInfo.Description is not null)
    {
        foreach (var line in GetNormalizedDescription(domainInfo.Description))
        {
            cdpModuleBuilder.AppendLine($"    /// {line}");
        }
    }
    cdpModuleBuilder.AppendLine("    /// </summary>");

    if (domainInfo.Experimental is true)
    {
        cdpModuleBuilder.AppendLine($"    [global::System.Diagnostics.CodeAnalysis.Experimental(\"{experimentalDiagnosticId}\")]");
    }

    if (domainInfo.Deprecated is true)
    {
        cdpModuleBuilder.AppendLine("    [global::System.Obsolete]");
    }

    // Generate the property
    cdpModuleBuilder.AppendLine($"    public {domainInfo.Domain}.I{domainInfo.Domain} {domainInfo.Domain} => _{propertyNameCamelCase} ?? global::System.Threading.Interlocked.CompareExchange(ref _{propertyNameCamelCase}, new {domainInfo.Domain}.{domainInfo.Domain}Domain(this), null) ?? _{propertyNameCamelCase};");
    cdpModuleBuilder.AppendLine();
}

cdpModuleBuilder.AppendLine("#pragma warning restore BIDICDP001");
cdpModuleBuilder.AppendLine("#pragma warning restore CS0612");
cdpModuleBuilder.AppendLine("}");

File.WriteAllText($"{outputDirectory}/CdpModule.g.cs", cdpModuleBuilder.ToString());

static void AppendSummary(StringBuilder builder, string? description, string indent = "")
{
    builder.AppendLine($"{indent}/// <summary>");
    if (description is not null)
    {
        foreach (var line in GetNormalizedDescription(description))
        {
            builder.AppendLine($"{indent}/// {line}");
        }
    }
    builder.AppendLine($"{indent}/// </summary>");
}

static void AppendAvailabilityAttributes(StringBuilder builder, bool isExperimental, bool isDeprecated, string indent = "")
{
    if (isExperimental)
    {
        builder.AppendLine($"{indent}[global::System.Diagnostics.CodeAnalysis.Experimental(\"{experimentalDiagnosticId}\")]");
    }

    if (isDeprecated)
    {
        builder.AppendLine($"{indent}[global::System.Obsolete]");
    }
}

static void AppendCommandDocumentation(StringBuilder builder, CommandInfo commandInfo, string indent)
{
    AppendSummary(builder, commandInfo.Description, indent);

    if (commandInfo.Parameters is not null)
    {
        foreach (var parameterInfo in commandInfo.Parameters.Where(p => p.Optional is not true))
        {
            AppendParameterDocumentation(builder, parameterInfo.Name, parameterInfo.Description, indent);
        }

        foreach (var parameterInfo in commandInfo.Parameters.Where(p => p.Optional is true))
        {
            AppendParameterDocumentation(builder, parameterInfo.Name, parameterInfo.Description, indent);
        }
    }

    AppendParameterDocumentation(builder, GetSessionArgumentName(commandInfo), "Optional CDP session override.", indent);
    AppendParameterDocumentation(builder, "cancellationToken", "A token to cancel the asynchronous operation.", indent);
    builder.AppendLine($"{indent}/// <returns>");
    builder.AppendLine($"{indent}/// A task representing the asynchronous operation, containing a <see cref=\"{commandInfo.Name.Dehumanize()}Result\"/>.");
    builder.AppendLine($"{indent}/// </returns>");
}

static void AppendEventDocumentation(StringBuilder builder, EventInfo eventInfo, string indent)
{
    AppendSummary(builder, eventInfo.Description ?? string.Empty, indent);

    if (eventInfo.Parameters is { Count: > 0 })
    {
        builder.AppendLine($"{indent}/// <remarks>");
        builder.AppendLine($"{indent}/// Event args (<see cref=\"{eventInfo.Name.Dehumanize()}EventArgs\"/>):");
        builder.AppendLine($"{indent}/// <list type=\"bullet\">");
        foreach (var parameterInfo in eventInfo.Parameters)
        {
            var description = parameterInfo.Description is not null
                ? " - " + string.Join(" ", GetNormalizedDescription(parameterInfo.Description))
                : string.Empty;
            builder.AppendLine($"{indent}/// <item><description><b>{parameterInfo.Name.Dehumanize()}</b>{description}</description></item>");
        }
        builder.AppendLine($"{indent}/// </list>");
        builder.AppendLine($"{indent}/// </remarks>");
    }
}

static void AppendParameterDocumentation(StringBuilder builder, string parameterName, string? description, string indent)
{
    builder.AppendLine($"{indent}/// <param name=\"{parameterName}\">");
    if (description is not null)
    {
        foreach (var line in GetNormalizedDescription(description))
        {
            builder.AppendLine($"{indent}/// {line}");
        }
    }
    builder.AppendLine($"{indent}/// </param>");
}

static string GetSessionArgumentName(CommandInfo commandInfo)
{
    return commandInfo.Parameters?.FirstOrDefault(p => p.Name == "session") is not null
        ? "cdpSession"
        : "session";
}

static string GetCommandSignature(CommandInfo commandInfo, bool includeDefaultValues)
{
    var parameters = new List<string>();

    if (commandInfo.Parameters is not null)
    {
        foreach (var parameterInfo in commandInfo.Parameters.Where(p => p.Optional is not true))
        {
            parameters.Add($"{parameterInfo.AsCSharpType()} {EscapeIdentifier(parameterInfo.Name)}");
        }

        foreach (var parameterInfo in commandInfo.Parameters.Where(p => p.Optional is true))
        {
            var defaultValue = includeDefaultValues ? " = default" : string.Empty;
            parameters.Add($"{parameterInfo.AsCSharpType()} {EscapeIdentifier(parameterInfo.Name)}{defaultValue}");
        }
    }

    var sessionDefault = includeDefaultValues ? " = default" : string.Empty;
    parameters.Add($"string? {GetSessionArgumentName(commandInfo)}{sessionDefault}");
    parameters.Add(includeDefaultValues
        ? "CancellationToken cancellationToken = default"
        : "CancellationToken cancellationToken");

    return string.Join(", ", parameters);
}

static string GetCommandParameterInitializer(CommandInfo commandInfo)
{
    if (commandInfo.Parameters is null)
    {
        return string.Empty;
    }

    return string.Join(", ", commandInfo.Parameters.Select(parameterInfo => $"{parameterInfo.Name.Dehumanize()}: {EscapeIdentifier(parameterInfo.Name)}"));
}

static string EscapeIdentifier(string identifier)
{
    return identifier == "override"
        ? "@override"
        : identifier;
}

static string[] GetNormalizedDescription(string description)
{
    // Escape XML special characters first so raw HTML from the spec doesn't break XML doc comments
    description = description.Replace("&", "&amp;").Replace("<", "&lt;").Replace(">", "&gt;");
    return CommentBlockRegex().Replace(description, "<b>$1</b>").Split('\n');
}

partial class Program
{
    [GeneratedRegex("`(.*?)`")]
    private static partial Regex CommentBlockRegex();
}

static class Extensions
{
    public static readonly HashSet<string> DictionaryTypes = new();
    public static readonly Dictionary<string, PropertyInfoItem> ArrayTypes = new();

    public static string AsCSharpType(this ReturnInfo returnInfo)
    {
        var res = GetPrimitiveCSharpType(returnInfo.Type, returnInfo.Ref);

        if (res is null)
        {
            if (returnInfo.Type == "array")
            {
                res = $"ImmutableArray<{GetPrimitiveCSharpType(returnInfo.Items!.Type, returnInfo.Items.Ref)}>";
            }
            else
            {
                throw new Exception($"Unknown return type: {returnInfo}");
            }
        }

        if (returnInfo.Optional is true)
        {
            res += "?";
        }

        return res;
    }

    public static string AsCSharpType(this ParameterInfo parameterInfo)
    {
        var res = GetPrimitiveCSharpType(parameterInfo.Type, parameterInfo.Ref);

        if (res is null)
        {
            if (parameterInfo.Type == "array")
            {
                res = $"ImmutableArray<{GetPrimitiveCSharpType(parameterInfo.Items!.Type, parameterInfo.Items.Ref)}>";
            }
            else
            {
                throw new Exception($"Unknown parameter type: {parameterInfo}");
            }
        }

        if (parameterInfo.Optional is true)
        {
            res += "?";
        }

        return res;
    }

    public static string AsCSharpType(this PropertyInfo propertyInfo)
    {
        var res = GetPrimitiveCSharpType(propertyInfo.Type, propertyInfo.Ref);

        if (res is null)
        {
            if (propertyInfo.Type == "array")
            {
                res = $"ImmutableArray<{GetPrimitiveCSharpType(propertyInfo.Items!.Type, propertyInfo.Items.Ref)}>";
            }
            else
            {
                throw new Exception($"Unknown property type: {propertyInfo}");
            }
        }

        if (propertyInfo.Optional is true)
        {
            res += "?";
        }

        return res;
    }

    private static string? GetPrimitiveCSharpType(string? cdpType, string? @ref)
    {
        if (cdpType is null && @ref is not null)
        {
            // Strip domain prefix (e.g. "Security.MixedContentType" -> "MixedContentType")
            var typeName = @ref.Contains('.') ? @ref.Split('.')[1] : @ref;
            if (DictionaryTypes.Contains(typeName))
            {
                return "global::System.Collections.Generic.IReadOnlyDictionary<string, string>";
            }
            if (ArrayTypes.TryGetValue(typeName, out var itemInfo))
            {
                var itemType = GetPrimitiveCSharpType(itemInfo.Type, itemInfo.Ref) ?? "global::System.Text.Json.JsonElement";
                return $"ImmutableArray<{itemType}>";
            }
            return @ref;
        }

        return cdpType switch
        {
            "string" => "string",
            "number" => "double",
            "integer" => "long",
            "boolean" => "bool",
            "object" => "global::System.Text.Json.JsonElement",
            "any" => "global::System.Text.Json.JsonElement",
            _ => null,
        };
    }
}