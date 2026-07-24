#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.Autofill;

/// <summary>
/// Defines commands and events for Autofill.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IAutofill
{
    /// <summary>
    /// Trigger autofill on a form identified by the fieldId.
    /// If the field and related form cannot be autofilled, returns an error.
    /// </summary>
    /// <param name="fieldId">
    /// Identifies a field that serves as an anchor for autofill.
    /// </param>
    /// <param name="frameId">
    /// Identifies the frame that field belongs to.
    /// </param>
    /// <param name="card">
    /// Credit card information to fill out the form. Credit card data is not saved.  Mutually exclusive with <b>address</b>.
    /// </param>
    /// <param name="address">
    /// Address to fill out the form. Address data is not saved. Mutually exclusive with <b>card</b>.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="TriggerResult"/>.
    /// </returns>
    Task<TriggerResult> TriggerAsync(DOM.BackendNodeId fieldId, Page.FrameId? frameId = default, CreditCard? card = default, Address? address = default, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set addresses so that developers can verify their forms implementation.
    /// </summary>
    /// <param name="addresses">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetAddressesResult"/>.
    /// </returns>
    Task<SetAddressesResult> SetAddressesAsync(ImmutableArray<Address> addresses, string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disables autofill domain notifications.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisableResult"/>.
    /// </returns>
    Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Enables autofill domain notifications.
    /// </summary>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default);

    /// <summary>
    /// Emitted when an address form is filled.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="AddressFormFilledEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>FilledFields</b> - Information about the fields that were filled</description></item>
    /// <item><description><b>AddressUi</b> - An UI representation of the address used to fill the form. Consists of a 2D array where each child represents an address/profile line.</description></item>
    /// </list>
    /// </remarks>
    IEventSource<AddressFormFilledEventArgs> AddressFormFilled { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class AutofillDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IAutofill
{
    private static AutofillJsonSerializerContext JsonContext = AutofillJsonSerializerContext.Default;

    public async Task<TriggerResult> TriggerAsync(DOM.BackendNodeId fieldId, Page.FrameId? frameId = default, CreditCard? card = default, Address? address = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new TriggerCommandParameters(FieldId: fieldId, FrameId: frameId, Card: card, Address: address);
        return await ExecuteCommandAsync(TriggerCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<TriggerCommandParameters, TriggerResult> TriggerCommand = new("Autofill.trigger", JsonContext.TriggerCommandParameters, JsonContext.TriggerResult);

    public async Task<SetAddressesResult> SetAddressesAsync(ImmutableArray<Address> addresses, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetAddressesCommandParameters(Addresses: addresses);
        return await ExecuteCommandAsync(SetAddressesCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetAddressesCommandParameters, SetAddressesResult> SetAddressesCommand = new("Autofill.setAddresses", JsonContext.SetAddressesCommandParameters, JsonContext.SetAddressesResult);

    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("Autofill.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    public async Task<EnableResult> EnableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("Autofill.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    public IEventSource<AddressFormFilledEventArgs> AddressFormFilled => CreateCdpEventSource(AutofillDomainEvent.AddressFormFilled);
}

internal sealed record TriggerCommandParameters(DOM.BackendNodeId FieldId, Page.FrameId? FrameId, CreditCard? Card, Address? Address) : Parameters;

/// <summary>
/// </summary>
public sealed record TriggerResult() : EmptyResult;


internal sealed record SetAddressesCommandParameters(ImmutableArray<Address> Addresses) : Parameters;

/// <summary>
/// </summary>
public sealed record SetAddressesResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


/// <summary>
/// Emitted when an address form is filled.
/// </summary>
/// <param name="FilledFields">
/// Information about the fields that were filled
/// </param>
/// <param name="AddressUi">
/// An UI representation of the address used to fill the form.
/// Consists of a 2D array where each child represents an address/profile line.
/// </param>
public sealed record AddressFormFilledEventArgs(ImmutableArray<FilledField> FilledFields, AddressUI AddressUi) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// </summary>
/// <param name="Number">
/// 16-digit credit card number.
/// </param>
/// <param name="Name">
/// Name of the credit card owner.
/// </param>
/// <param name="ExpiryMonth">
/// 2-digit expiry month.
/// </param>
/// <param name="ExpiryYear">
/// 4-digit expiry year.
/// </param>
/// <param name="Cvc">
/// 3-digit card verification code.
/// </param>
public sealed record CreditCard(string Number, string Name, string ExpiryMonth, string ExpiryYear, string Cvc)
{
}

/// <summary>
/// </summary>
/// <param name="Name">
/// address field name, for example GIVEN_NAME.
/// The full list of supported field names:
/// https://source.chromium.org/chromium/chromium/src/+/main:components/autofill/core/browser/field_types.cc;l=38
/// </param>
/// <param name="Value">
/// address field value, for example Jon Doe.
/// </param>
public sealed record AddressField(string Name, string Value)
{
}

/// <summary>
/// A list of address fields.
/// </summary>
/// <param name="Fields">
/// </param>
public sealed record AddressFields(ImmutableArray<AddressField> Fields)
{
}

/// <summary>
/// </summary>
/// <param name="Fields">
/// fields and values defining an address.
/// </param>
public sealed record Address(ImmutableArray<AddressField> Fields)
{
}

/// <summary>
/// Defines how an address can be displayed like in chrome://settings/addresses.
/// Address UI is a two dimensional array, each inner array is an "address information line", and when rendered in a UI surface should be displayed as such.
/// The following address UI for instance:
/// [[{name: "GIVE_NAME", value: "Jon"}, {name: "FAMILY_NAME", value: "Doe"}], [{name: "CITY", value: "Munich"}, {name: "ZIP", value: "81456"}]]
/// should allow the receiver to render:
/// Jon Doe
/// Munich 81456
/// </summary>
/// <param name="AddressFields">
/// A two dimension array containing the representation of values from an address profile.
/// </param>
public sealed record AddressUI(ImmutableArray<AddressFields> AddressFields)
{
}

/// <summary>
/// Specified whether a filled field was done so by using the html autocomplete attribute or autofill heuristics.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<FillingStrategy>))]
public enum FillingStrategy
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autocompleteAttribute")]
    AutocompleteAttribute,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("autofillInferred")]
    AutofillInferred,
}

/// <summary>
/// </summary>
/// <param name="HtmlType">
/// The type of the field, e.g text, password etc.
/// </param>
/// <param name="Id">
/// the html id
/// </param>
/// <param name="Name">
/// the html name
/// </param>
/// <param name="Value">
/// the field value
/// </param>
/// <param name="AutofillType">
/// The actual field type, e.g FAMILY_NAME
/// </param>
/// <param name="FillingStrategy">
/// The filling strategy
/// </param>
/// <param name="FrameId">
/// The frame the field belongs to
/// </param>
/// <param name="FieldId">
/// The form field's DOM node
/// </param>
public sealed record FilledField(string HtmlType, string Id, string Name, string Value, string AutofillType, FillingStrategy FillingStrategy, Page.FrameId FrameId, DOM.BackendNodeId FieldId)
{
}

[JsonSerializable(typeof(TriggerCommandParameters), TypeInfoPropertyName = "TriggerCommandParameters")]
[JsonSerializable(typeof(TriggerResult), TypeInfoPropertyName = "TriggerResult")]
[JsonSerializable(typeof(SetAddressesCommandParameters), TypeInfoPropertyName = "SetAddressesCommandParameters")]
[JsonSerializable(typeof(SetAddressesResult), TypeInfoPropertyName = "SetAddressesResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(CdpEventArgs<AddressFormFilledEventArgs>), TypeInfoPropertyName = "AddressFormFilledCdpEventArgs")]
[JsonSerializable(typeof(CreditCard), TypeInfoPropertyName = "AutofillCreditCard")]
[JsonSerializable(typeof(AddressField), TypeInfoPropertyName = "AutofillAddressField")]
[JsonSerializable(typeof(AddressFields), TypeInfoPropertyName = "AutofillAddressFields")]
[JsonSerializable(typeof(Address), TypeInfoPropertyName = "AutofillAddress")]
[JsonSerializable(typeof(AddressUI), TypeInfoPropertyName = "AutofillAddressUI")]
[JsonSerializable(typeof(FillingStrategy), TypeInfoPropertyName = "AutofillFillingStrategy")]
[JsonSerializable(typeof(FilledField), TypeInfoPropertyName = "AutofillFilledField")]
[JsonSerializable(typeof(ImmutableArray<Address>), TypeInfoPropertyName = "ImmutableArrayAutofillAddress")]
[JsonSerializable(typeof(ImmutableArray<FilledField>), TypeInfoPropertyName = "ImmutableArrayAutofillFilledField")]
[JsonSerializable(typeof(ImmutableArray<AddressField>), TypeInfoPropertyName = "ImmutableArrayAutofillAddressField")]
[JsonSerializable(typeof(ImmutableArray<AddressFields>), TypeInfoPropertyName = "ImmutableArrayAutofillAddressFields")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class AutofillJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IAutofill"/>.
/// </summary>
public static class AutofillDomainEvent
{
    /// <summary>
    /// Emitted when an address form is filled.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<AddressFormFilledEventArgs>> AddressFormFilled { get; } =
        EventDescriptor<CdpEventArgs<AddressFormFilledEventArgs>>.Create(
            "goog:cdp.Autofill.addressFormFilled",
            AutofillJsonSerializerContext.Default.AddressFormFilledCdpEventArgs);

}
