#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Schema;

/// <summary>
/// This domain is deprecated.
/// </summary>
[global::System.Obsolete]
public sealed class SchemaDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static SchemaJsonSerializerContext JsonContext = SchemaJsonSerializerContext.Default;

    /// <summary>
    /// Returns supported domains.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="GetDomainsCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="GetDomainsResult"/>.
    /// </returns>
    public async Task<GetDomainsResult> GetDomainsAsync(GetDomainsCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new GetDomainsCommandParameters();
        return await ExecuteCommandAsync(GetDomainsCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<GetDomainsCommandParameters, GetDomainsResult> GetDomainsCommand = new("Schema.getDomains", JsonContext.GetDomainsCommandParameters, JsonContext.GetDomainsResult);

}

internal sealed record GetDomainsCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="SchemaDomain.GetDomainsAsync"/>.
/// </summary>
public sealed record GetDomainsCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
/// <param name="Domains">
/// List of supported domains.
/// </param>
public sealed record GetDomainsResult(IReadOnlyList<Domain> Domains) : EmptyResult;


/// <summary>
/// Description of the protocol domain.
/// </summary>
/// <param name="Name">
/// Domain name.
/// </param>
/// <param name="Version">
/// Domain version.
/// </param>
public sealed record Domain(string Name, string Version)
{
}

[JsonSerializable(typeof(GetDomainsCommandParameters), TypeInfoPropertyName = "GetDomainsCommandParameters")]
[JsonSerializable(typeof(GetDomainsResult), TypeInfoPropertyName = "GetDomainsResult")]
[JsonSerializable(typeof(Domain), TypeInfoPropertyName = "SchemaDomain")]
[JsonSerializable(typeof(global::System.Collections.Generic.IReadOnlyList<Domain>), TypeInfoPropertyName = "IReadOnlyListSchemaDomain")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class SchemaJsonSerializerContext : JsonSerializerContext;

