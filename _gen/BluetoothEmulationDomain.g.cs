#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.BluetoothEmulation;

/// <summary>
/// This domain allows configuring virtual Bluetooth devices to test
/// the web-bluetooth API.
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public interface IBluetoothEmulation
{
    /// <summary>
    /// Enable the BluetoothEmulation domain.
    /// </summary>
    /// <param name="state">
    /// State of the simulated central.
    /// </param>
    /// <param name="leSupported">
    /// If the simulated central supports low-energy.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    Task<EnableResult> EnableAsync(CentralState state, bool leSupported, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Set the state of the simulated central.
    /// </summary>
    /// <param name="state">
    /// State of the simulated central.
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SetSimulatedCentralStateResult"/>.
    /// </returns>
    Task<SetSimulatedCentralStateResult> SetSimulatedCentralStateAsync(CentralState state, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Disable the BluetoothEmulation domain.
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
    Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulates a peripheral with |address|, |name| and |knownServiceUuids|
    /// that has already been connected to the system.
    /// </summary>
    /// <param name="address">
    /// </param>
    /// <param name="name">
    /// </param>
    /// <param name="manufacturerData">
    /// </param>
    /// <param name="knownServiceUuids">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SimulatePreconnectedPeripheralResult"/>.
    /// </returns>
    Task<SimulatePreconnectedPeripheralResult> SimulatePreconnectedPeripheralAsync(string address, string name, ImmutableArray<ManufacturerData> manufacturerData, ImmutableArray<string> knownServiceUuids, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulates an advertisement packet described in |entry| being received by
    /// the central.
    /// </summary>
    /// <param name="entry">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SimulateAdvertisementResult"/>.
    /// </returns>
    Task<SimulateAdvertisementResult> SimulateAdvertisementAsync(ScanEntry entry, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulates the response code from the peripheral with |address| for a
    /// GATT operation of |type|. The |code| value follows the HCI Error Codes from
    /// Bluetooth Core Specification Vol 2 Part D 1.3 List Of Error Codes.
    /// </summary>
    /// <param name="address">
    /// </param>
    /// <param name="type">
    /// </param>
    /// <param name="code">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SimulateGATTOperationResponseResult"/>.
    /// </returns>
    Task<SimulateGATTOperationResponseResult> SimulateGATTOperationResponseAsync(string address, GATTOperationType type, long code, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulates the response from the characteristic with |characteristicId| for a
    /// characteristic operation of |type|. The |code| value follows the Error
    /// Codes from Bluetooth Core Specification Vol 3 Part F 3.4.1.1 Error Response.
    /// The |data| is expected to exist when simulating a successful read operation
    /// response.
    /// </summary>
    /// <param name="characteristicId">
    /// </param>
    /// <param name="type">
    /// </param>
    /// <param name="code">
    /// </param>
    /// <param name="data">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SimulateCharacteristicOperationResponseResult"/>.
    /// </returns>
    Task<SimulateCharacteristicOperationResponseResult> SimulateCharacteristicOperationResponseAsync(string characteristicId, CharacteristicOperationType type, long code, string? data = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulates the response from the descriptor with |descriptorId| for a
    /// descriptor operation of |type|. The |code| value follows the Error
    /// Codes from Bluetooth Core Specification Vol 3 Part F 3.4.1.1 Error Response.
    /// The |data| is expected to exist when simulating a successful read operation
    /// response.
    /// </summary>
    /// <param name="descriptorId">
    /// </param>
    /// <param name="type">
    /// </param>
    /// <param name="code">
    /// </param>
    /// <param name="data">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SimulateDescriptorOperationResponseResult"/>.
    /// </returns>
    Task<SimulateDescriptorOperationResponseResult> SimulateDescriptorOperationResponseAsync(string descriptorId, DescriptorOperationType type, long code, string? data = null, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds a service with |serviceUuid| to the peripheral with |address|.
    /// </summary>
    /// <param name="address">
    /// </param>
    /// <param name="serviceUuid">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddServiceResult"/>.
    /// </returns>
    Task<AddServiceResult> AddServiceAsync(string address, string serviceUuid, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes the service respresented by |serviceId| from the simulated central.
    /// </summary>
    /// <param name="serviceId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveServiceResult"/>.
    /// </returns>
    Task<RemoveServiceResult> RemoveServiceAsync(string serviceId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds a characteristic with |characteristicUuid| and |properties| to the
    /// service represented by |serviceId|.
    /// </summary>
    /// <param name="serviceId">
    /// </param>
    /// <param name="characteristicUuid">
    /// </param>
    /// <param name="properties">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddCharacteristicResult"/>.
    /// </returns>
    Task<AddCharacteristicResult> AddCharacteristicAsync(string serviceId, string characteristicUuid, CharacteristicProperties properties, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes the characteristic respresented by |characteristicId| from the
    /// simulated central.
    /// </summary>
    /// <param name="characteristicId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveCharacteristicResult"/>.
    /// </returns>
    Task<RemoveCharacteristicResult> RemoveCharacteristicAsync(string characteristicId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Adds a descriptor with |descriptorUuid| to the characteristic respresented
    /// by |characteristicId|.
    /// </summary>
    /// <param name="characteristicId">
    /// </param>
    /// <param name="descriptorUuid">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="AddDescriptorResult"/>.
    /// </returns>
    Task<AddDescriptorResult> AddDescriptorAsync(string characteristicId, string descriptorUuid, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Removes the descriptor with |descriptorId| from the simulated central.
    /// </summary>
    /// <param name="descriptorId">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="RemoveDescriptorResult"/>.
    /// </returns>
    Task<RemoveDescriptorResult> RemoveDescriptorAsync(string descriptorId, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Simulates a GATT disconnection from the peripheral with |address|.
    /// </summary>
    /// <param name="address">
    /// </param>
    /// <param name="session">
    /// Optional CDP session override.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="SimulateGATTDisconnectionResult"/>.
    /// </returns>
    Task<SimulateGATTDisconnectionResult> SimulateGATTDisconnectionAsync(string address, string? session = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Event for when a GATT operation of |type| to the peripheral with |address|
    /// happened.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="GattOperationReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>Address</b></description></item>
    /// <item><description><b>Type</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<GattOperationReceivedEventArgs> GattOperationReceived { get; }

    /// <summary>
    /// Event for when a characteristic operation of |type| to the characteristic
    /// respresented by |characteristicId| happened. |data| and |writeType| is
    /// expected to exist when |type| is write.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CharacteristicOperationReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>CharacteristicId</b></description></item>
    /// <item><description><b>Type</b></description></item>
    /// <item><description><b>Data</b></description></item>
    /// <item><description><b>WriteType</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<CharacteristicOperationReceivedEventArgs> CharacteristicOperationReceived { get; }

    /// <summary>
    /// Event for when a descriptor operation of |type| to the descriptor
    /// respresented by |descriptorId| happened. |data| is expected to exist when
    /// |type| is write.
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DescriptorOperationReceivedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>DescriptorId</b></description></item>
    /// <item><description><b>Type</b></description></item>
    /// <item><description><b>Data</b></description></item>
    /// </list>
    /// </remarks>
    IEventSource<DescriptorOperationReceivedEventArgs> DescriptorOperationReceived { get; }

}

[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
internal sealed class BluetoothEmulationDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp), IBluetoothEmulation
{
    private static readonly BluetoothEmulationJsonSerializerContext JsonContext = BluetoothEmulationJsonSerializerContext.Default;

    public async Task<EnableResult> EnableAsync(CentralState state, bool leSupported, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(State: state, LeSupported: leSupported);
        return await ExecuteCommandAsync("BluetoothEmulation.enable", @params, JsonContext.EnableCommandParameters, JsonContext.EnableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SetSimulatedCentralStateResult> SetSimulatedCentralStateAsync(CentralState state, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SetSimulatedCentralStateCommandParameters(State: state);
        return await ExecuteCommandAsync("BluetoothEmulation.setSimulatedCentralState", @params, JsonContext.SetSimulatedCentralStateCommandParameters, JsonContext.SetSimulatedCentralStateResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<DisableResult> DisableAsync(string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync("BluetoothEmulation.disable", @params, JsonContext.DisableCommandParameters, JsonContext.DisableResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SimulatePreconnectedPeripheralResult> SimulatePreconnectedPeripheralAsync(string address, string name, ImmutableArray<ManufacturerData> manufacturerData, ImmutableArray<string> knownServiceUuids, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SimulatePreconnectedPeripheralCommandParameters(Address: address, Name: name, ManufacturerData: manufacturerData, KnownServiceUuids: knownServiceUuids);
        return await ExecuteCommandAsync("BluetoothEmulation.simulatePreconnectedPeripheral", @params, JsonContext.SimulatePreconnectedPeripheralCommandParameters, JsonContext.SimulatePreconnectedPeripheralResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SimulateAdvertisementResult> SimulateAdvertisementAsync(ScanEntry entry, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateAdvertisementCommandParameters(Entry: entry);
        return await ExecuteCommandAsync("BluetoothEmulation.simulateAdvertisement", @params, JsonContext.SimulateAdvertisementCommandParameters, JsonContext.SimulateAdvertisementResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SimulateGATTOperationResponseResult> SimulateGATTOperationResponseAsync(string address, GATTOperationType type, long code, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateGATTOperationResponseCommandParameters(Address: address, Type: type, Code: code);
        return await ExecuteCommandAsync("BluetoothEmulation.simulateGATTOperationResponse", @params, JsonContext.SimulateGATTOperationResponseCommandParameters, JsonContext.SimulateGATTOperationResponseResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SimulateCharacteristicOperationResponseResult> SimulateCharacteristicOperationResponseAsync(string characteristicId, CharacteristicOperationType type, long code, string? data = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateCharacteristicOperationResponseCommandParameters(CharacteristicId: characteristicId, Type: type, Code: code, Data: data);
        return await ExecuteCommandAsync("BluetoothEmulation.simulateCharacteristicOperationResponse", @params, JsonContext.SimulateCharacteristicOperationResponseCommandParameters, JsonContext.SimulateCharacteristicOperationResponseResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SimulateDescriptorOperationResponseResult> SimulateDescriptorOperationResponseAsync(string descriptorId, DescriptorOperationType type, long code, string? data = null, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateDescriptorOperationResponseCommandParameters(DescriptorId: descriptorId, Type: type, Code: code, Data: data);
        return await ExecuteCommandAsync("BluetoothEmulation.simulateDescriptorOperationResponse", @params, JsonContext.SimulateDescriptorOperationResponseCommandParameters, JsonContext.SimulateDescriptorOperationResponseResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<AddServiceResult> AddServiceAsync(string address, string serviceUuid, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new AddServiceCommandParameters(Address: address, ServiceUuid: serviceUuid);
        return await ExecuteCommandAsync("BluetoothEmulation.addService", @params, JsonContext.AddServiceCommandParameters, JsonContext.AddServiceResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<RemoveServiceResult> RemoveServiceAsync(string serviceId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveServiceCommandParameters(ServiceId: serviceId);
        return await ExecuteCommandAsync("BluetoothEmulation.removeService", @params, JsonContext.RemoveServiceCommandParameters, JsonContext.RemoveServiceResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<AddCharacteristicResult> AddCharacteristicAsync(string serviceId, string characteristicUuid, CharacteristicProperties properties, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new AddCharacteristicCommandParameters(ServiceId: serviceId, CharacteristicUuid: characteristicUuid, Properties: properties);
        return await ExecuteCommandAsync("BluetoothEmulation.addCharacteristic", @params, JsonContext.AddCharacteristicCommandParameters, JsonContext.AddCharacteristicResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<RemoveCharacteristicResult> RemoveCharacteristicAsync(string characteristicId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveCharacteristicCommandParameters(CharacteristicId: characteristicId);
        return await ExecuteCommandAsync("BluetoothEmulation.removeCharacteristic", @params, JsonContext.RemoveCharacteristicCommandParameters, JsonContext.RemoveCharacteristicResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<AddDescriptorResult> AddDescriptorAsync(string characteristicId, string descriptorUuid, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new AddDescriptorCommandParameters(CharacteristicId: characteristicId, DescriptorUuid: descriptorUuid);
        return await ExecuteCommandAsync("BluetoothEmulation.addDescriptor", @params, JsonContext.AddDescriptorCommandParameters, JsonContext.AddDescriptorResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<RemoveDescriptorResult> RemoveDescriptorAsync(string descriptorId, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveDescriptorCommandParameters(DescriptorId: descriptorId);
        return await ExecuteCommandAsync("BluetoothEmulation.removeDescriptor", @params, JsonContext.RemoveDescriptorCommandParameters, JsonContext.RemoveDescriptorResult, session, cancellationToken).ConfigureAwait(false);
    }

    public async Task<SimulateGATTDisconnectionResult> SimulateGATTDisconnectionAsync(string address, string? session = null, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateGATTDisconnectionCommandParameters(Address: address);
        return await ExecuteCommandAsync("BluetoothEmulation.simulateGATTDisconnection", @params, JsonContext.SimulateGATTDisconnectionCommandParameters, JsonContext.SimulateGATTDisconnectionResult, session, cancellationToken).ConfigureAwait(false);
    }

    public IEventSource<GattOperationReceivedEventArgs> GattOperationReceived => CreateCdpEventSource(BluetoothEmulationDomainEvent.GattOperationReceived);
    public IEventSource<CharacteristicOperationReceivedEventArgs> CharacteristicOperationReceived => CreateCdpEventSource(BluetoothEmulationDomainEvent.CharacteristicOperationReceived);
    public IEventSource<DescriptorOperationReceivedEventArgs> DescriptorOperationReceived => CreateCdpEventSource(BluetoothEmulationDomainEvent.DescriptorOperationReceived);
}

internal sealed record EnableCommandParameters(CentralState State, bool LeSupported) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.EnableAsync"/> command.
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record SetSimulatedCentralStateCommandParameters(CentralState State) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.SetSimulatedCentralStateAsync"/> command.
/// </summary>
public sealed record SetSimulatedCentralStateResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.DisableAsync"/> command.
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record SimulatePreconnectedPeripheralCommandParameters(string Address, string Name, ImmutableArray<ManufacturerData> ManufacturerData, ImmutableArray<string> KnownServiceUuids) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.SimulatePreconnectedPeripheralAsync"/> command.
/// </summary>
public sealed record SimulatePreconnectedPeripheralResult() : EmptyResult;


internal sealed record SimulateAdvertisementCommandParameters(ScanEntry Entry) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.SimulateAdvertisementAsync"/> command.
/// </summary>
public sealed record SimulateAdvertisementResult() : EmptyResult;


internal sealed record SimulateGATTOperationResponseCommandParameters(string Address, GATTOperationType Type, long Code) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.SimulateGATTOperationResponseAsync"/> command.
/// </summary>
public sealed record SimulateGATTOperationResponseResult() : EmptyResult;


internal sealed record SimulateCharacteristicOperationResponseCommandParameters(string CharacteristicId, CharacteristicOperationType Type, long Code, string? Data) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.SimulateCharacteristicOperationResponseAsync"/> command.
/// </summary>
public sealed record SimulateCharacteristicOperationResponseResult() : EmptyResult;


internal sealed record SimulateDescriptorOperationResponseCommandParameters(string DescriptorId, DescriptorOperationType Type, long Code, string? Data) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.SimulateDescriptorOperationResponseAsync"/> command.
/// </summary>
public sealed record SimulateDescriptorOperationResponseResult() : EmptyResult;


internal sealed record AddServiceCommandParameters(string Address, string ServiceUuid) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.AddServiceAsync"/> command.
/// </summary>
/// <param name="ServiceId">
/// An identifier that uniquely represents this service.
/// </param>
public sealed record AddServiceResult(string ServiceId) : EmptyResult;


internal sealed record RemoveServiceCommandParameters(string ServiceId) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.RemoveServiceAsync"/> command.
/// </summary>
public sealed record RemoveServiceResult() : EmptyResult;


internal sealed record AddCharacteristicCommandParameters(string ServiceId, string CharacteristicUuid, CharacteristicProperties Properties) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.AddCharacteristicAsync"/> command.
/// </summary>
/// <param name="CharacteristicId">
/// An identifier that uniquely represents this characteristic.
/// </param>
public sealed record AddCharacteristicResult(string CharacteristicId) : EmptyResult;


internal sealed record RemoveCharacteristicCommandParameters(string CharacteristicId) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.RemoveCharacteristicAsync"/> command.
/// </summary>
public sealed record RemoveCharacteristicResult() : EmptyResult;


internal sealed record AddDescriptorCommandParameters(string CharacteristicId, string DescriptorUuid) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.AddDescriptorAsync"/> command.
/// </summary>
/// <param name="DescriptorId">
/// An identifier that uniquely represents this descriptor.
/// </param>
public sealed record AddDescriptorResult(string DescriptorId) : EmptyResult;


internal sealed record RemoveDescriptorCommandParameters(string DescriptorId) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.RemoveDescriptorAsync"/> command.
/// </summary>
public sealed record RemoveDescriptorResult() : EmptyResult;


internal sealed record SimulateGATTDisconnectionCommandParameters(string Address) : Parameters;

/// <summary>
/// Result of the <see cref="IBluetoothEmulation.SimulateGATTDisconnectionAsync"/> command.
/// </summary>
public sealed record SimulateGATTDisconnectionResult() : EmptyResult;


/// <summary>
/// Event for when a GATT operation of |type| to the peripheral with |address|
/// happened.
/// </summary>
/// <param name="Address">
/// </param>
/// <param name="Type">
/// </param>
public sealed record GattOperationReceivedEventArgs(string Address, GATTOperationType Type) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event for when a characteristic operation of |type| to the characteristic
/// respresented by |characteristicId| happened. |data| and |writeType| is
/// expected to exist when |type| is write.
/// </summary>
/// <param name="CharacteristicId">
/// </param>
/// <param name="Type">
/// </param>
/// <param name="Data">
/// </param>
/// <param name="WriteType">
/// </param>
public sealed record CharacteristicOperationReceivedEventArgs(string CharacteristicId, CharacteristicOperationType Type, string? Data = null, CharacteristicWriteType? WriteType = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Event for when a descriptor operation of |type| to the descriptor
/// respresented by |descriptorId| happened. |data| is expected to exist when
/// |type| is write.
/// </summary>
/// <param name="DescriptorId">
/// </param>
/// <param name="Type">
/// </param>
/// <param name="Data">
/// </param>
public sealed record DescriptorOperationReceivedEventArgs(string DescriptorId, DescriptorOperationType Type, string? Data = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Indicates the various states of Central.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CentralState>))]
public enum CentralState
{
    /// <summary>
    /// Corresponds to the <c>"absent"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("absent")]
    Absent,
    /// <summary>
    /// Corresponds to the <c>"powered-off"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("powered-off")]
    PoweredOff,
    /// <summary>
    /// Corresponds to the <c>"powered-on"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("powered-on")]
    PoweredOn,
}

/// <summary>
/// Indicates the various types of GATT event.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<GATTOperationType>))]
public enum GATTOperationType
{
    /// <summary>
    /// Corresponds to the <c>"connection"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("connection")]
    Connection,
    /// <summary>
    /// Corresponds to the <c>"discovery"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("discovery")]
    Discovery,
}

/// <summary>
/// Indicates the various types of characteristic write.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CharacteristicWriteType>))]
public enum CharacteristicWriteType
{
    /// <summary>
    /// Corresponds to the <c>"write-default-deprecated"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write-default-deprecated")]
    WriteDefaultDeprecated,
    /// <summary>
    /// Corresponds to the <c>"write-with-response"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write-with-response")]
    WriteWithResponse,
    /// <summary>
    /// Corresponds to the <c>"write-without-response"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write-without-response")]
    WriteWithoutResponse,
}

/// <summary>
/// Indicates the various types of characteristic operation.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<CharacteristicOperationType>))]
public enum CharacteristicOperationType
{
    /// <summary>
    /// Corresponds to the <c>"read"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("read")]
    Read,
    /// <summary>
    /// Corresponds to the <c>"write"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write")]
    Write,
    /// <summary>
    /// Corresponds to the <c>"subscribe-to-notifications"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("subscribe-to-notifications")]
    SubscribeToNotifications,
    /// <summary>
    /// Corresponds to the <c>"unsubscribe-from-notifications"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unsubscribe-from-notifications")]
    UnsubscribeFromNotifications,
}

/// <summary>
/// Indicates the various types of descriptor operation.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<DescriptorOperationType>))]
public enum DescriptorOperationType
{
    /// <summary>
    /// Corresponds to the <c>"read"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("read")]
    Read,
    /// <summary>
    /// Corresponds to the <c>"write"</c> wire value.
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write")]
    Write,
}

/// <summary>
/// Stores the manufacturer data
/// </summary>
/// <param name="Key">
/// Company identifier
/// https://bitbucket.org/bluetooth-SIG/public/src/main/assigned_numbers/company_identifiers/company_identifiers.yaml
/// https://usb.org/developers
/// </param>
/// <param name="Data">
/// Manufacturer-specific data (Encoded as a base64 string when passed over JSON)
/// </param>
public sealed record ManufacturerData(long Key, string Data)
{
}

/// <summary>
/// Stores the byte data of the advertisement packet sent by a Bluetooth device.
/// </summary>
public sealed record ScanRecord()
{
    /// <summary>
    /// </summary>
    public string? Name { get; init; }

    /// <summary>
    /// </summary>
    public ImmutableArray<string>? Uuids { get; init; }

    /// <summary>
    /// Stores the external appearance description of the device.
    /// </summary>
    public long? Appearance { get; init; }

    /// <summary>
    /// Stores the transmission power of a broadcasting device.
    /// </summary>
    public long? TxPower { get; init; }

    /// <summary>
    /// Key is the company identifier and the value is an array of bytes of
    /// manufacturer specific data.
    /// </summary>
    public ImmutableArray<ManufacturerData>? ManufacturerData { get; init; }
}

/// <summary>
/// Stores the advertisement packet information that is sent by a Bluetooth device.
/// </summary>
/// <param name="DeviceAddress">
/// </param>
/// <param name="Rssi">
/// </param>
/// <param name="ScanRecord">
/// </param>
public sealed record ScanEntry(string DeviceAddress, long Rssi, ScanRecord ScanRecord)
{
}

/// <summary>
/// Describes the properties of a characteristic. This follows Bluetooth Core
/// Specification BT 4.2 Vol 3 Part G 3.3.1. Characteristic Properties.
/// </summary>
public sealed record CharacteristicProperties()
{
    /// <summary>
    /// </summary>
    public bool? Broadcast { get; init; }

    /// <summary>
    /// </summary>
    public bool? Read { get; init; }

    /// <summary>
    /// </summary>
    public bool? WriteWithoutResponse { get; init; }

    /// <summary>
    /// </summary>
    public bool? Write { get; init; }

    /// <summary>
    /// </summary>
    public bool? Notify { get; init; }

    /// <summary>
    /// </summary>
    public bool? Indicate { get; init; }

    /// <summary>
    /// </summary>
    public bool? AuthenticatedSignedWrites { get; init; }

    /// <summary>
    /// </summary>
    public bool? ExtendedProperties { get; init; }
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(SetSimulatedCentralStateCommandParameters), TypeInfoPropertyName = "SetSimulatedCentralStateCommandParameters")]
[JsonSerializable(typeof(SetSimulatedCentralStateResult), TypeInfoPropertyName = "SetSimulatedCentralStateResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(SimulatePreconnectedPeripheralCommandParameters), TypeInfoPropertyName = "SimulatePreconnectedPeripheralCommandParameters")]
[JsonSerializable(typeof(SimulatePreconnectedPeripheralResult), TypeInfoPropertyName = "SimulatePreconnectedPeripheralResult")]
[JsonSerializable(typeof(SimulateAdvertisementCommandParameters), TypeInfoPropertyName = "SimulateAdvertisementCommandParameters")]
[JsonSerializable(typeof(SimulateAdvertisementResult), TypeInfoPropertyName = "SimulateAdvertisementResult")]
[JsonSerializable(typeof(SimulateGATTOperationResponseCommandParameters), TypeInfoPropertyName = "SimulateGATTOperationResponseCommandParameters")]
[JsonSerializable(typeof(SimulateGATTOperationResponseResult), TypeInfoPropertyName = "SimulateGATTOperationResponseResult")]
[JsonSerializable(typeof(SimulateCharacteristicOperationResponseCommandParameters), TypeInfoPropertyName = "SimulateCharacteristicOperationResponseCommandParameters")]
[JsonSerializable(typeof(SimulateCharacteristicOperationResponseResult), TypeInfoPropertyName = "SimulateCharacteristicOperationResponseResult")]
[JsonSerializable(typeof(SimulateDescriptorOperationResponseCommandParameters), TypeInfoPropertyName = "SimulateDescriptorOperationResponseCommandParameters")]
[JsonSerializable(typeof(SimulateDescriptorOperationResponseResult), TypeInfoPropertyName = "SimulateDescriptorOperationResponseResult")]
[JsonSerializable(typeof(AddServiceCommandParameters), TypeInfoPropertyName = "AddServiceCommandParameters")]
[JsonSerializable(typeof(AddServiceResult), TypeInfoPropertyName = "AddServiceResult")]
[JsonSerializable(typeof(RemoveServiceCommandParameters), TypeInfoPropertyName = "RemoveServiceCommandParameters")]
[JsonSerializable(typeof(RemoveServiceResult), TypeInfoPropertyName = "RemoveServiceResult")]
[JsonSerializable(typeof(AddCharacteristicCommandParameters), TypeInfoPropertyName = "AddCharacteristicCommandParameters")]
[JsonSerializable(typeof(AddCharacteristicResult), TypeInfoPropertyName = "AddCharacteristicResult")]
[JsonSerializable(typeof(RemoveCharacteristicCommandParameters), TypeInfoPropertyName = "RemoveCharacteristicCommandParameters")]
[JsonSerializable(typeof(RemoveCharacteristicResult), TypeInfoPropertyName = "RemoveCharacteristicResult")]
[JsonSerializable(typeof(AddDescriptorCommandParameters), TypeInfoPropertyName = "AddDescriptorCommandParameters")]
[JsonSerializable(typeof(AddDescriptorResult), TypeInfoPropertyName = "AddDescriptorResult")]
[JsonSerializable(typeof(RemoveDescriptorCommandParameters), TypeInfoPropertyName = "RemoveDescriptorCommandParameters")]
[JsonSerializable(typeof(RemoveDescriptorResult), TypeInfoPropertyName = "RemoveDescriptorResult")]
[JsonSerializable(typeof(SimulateGATTDisconnectionCommandParameters), TypeInfoPropertyName = "SimulateGATTDisconnectionCommandParameters")]
[JsonSerializable(typeof(SimulateGATTDisconnectionResult), TypeInfoPropertyName = "SimulateGATTDisconnectionResult")]
[JsonSerializable(typeof(CdpEventArgs<GattOperationReceivedEventArgs>), TypeInfoPropertyName = "GattOperationReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CharacteristicOperationReceivedEventArgs>), TypeInfoPropertyName = "CharacteristicOperationReceivedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DescriptorOperationReceivedEventArgs>), TypeInfoPropertyName = "DescriptorOperationReceivedCdpEventArgs")]
[JsonSerializable(typeof(CentralState), TypeInfoPropertyName = "BluetoothEmulationCentralState")]
[JsonSerializable(typeof(GATTOperationType), TypeInfoPropertyName = "BluetoothEmulationGATTOperationType")]
[JsonSerializable(typeof(CharacteristicWriteType), TypeInfoPropertyName = "BluetoothEmulationCharacteristicWriteType")]
[JsonSerializable(typeof(CharacteristicOperationType), TypeInfoPropertyName = "BluetoothEmulationCharacteristicOperationType")]
[JsonSerializable(typeof(DescriptorOperationType), TypeInfoPropertyName = "BluetoothEmulationDescriptorOperationType")]
[JsonSerializable(typeof(ManufacturerData), TypeInfoPropertyName = "BluetoothEmulationManufacturerData")]
[JsonSerializable(typeof(ScanRecord), TypeInfoPropertyName = "BluetoothEmulationScanRecord")]
[JsonSerializable(typeof(ScanEntry), TypeInfoPropertyName = "BluetoothEmulationScanEntry")]
[JsonSerializable(typeof(CharacteristicProperties), TypeInfoPropertyName = "BluetoothEmulationCharacteristicProperties")]
[JsonSerializable(typeof(ImmutableArray<ManufacturerData>), TypeInfoPropertyName = "ImmutableArrayBluetoothEmulationManufacturerData")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class BluetoothEmulationJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="IBluetoothEmulation"/>.
/// </summary>
public static class BluetoothEmulationDomainEvent
{
    /// <summary>
    /// Event for when a GATT operation of |type| to the peripheral with |address|
    /// happened.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<GattOperationReceivedEventArgs>> GattOperationReceived =>
        _gattOperationReceived ?? global::System.Threading.Interlocked.CompareExchange(ref _gattOperationReceived, EventDescriptor<CdpEventArgs<GattOperationReceivedEventArgs>>.Create(
            "goog:cdp.BluetoothEmulation.gattOperationReceived",
            BluetoothEmulationJsonSerializerContext.Default.GattOperationReceivedCdpEventArgs), null) ?? _gattOperationReceived;
    private static EventDescriptor<CdpEventArgs<GattOperationReceivedEventArgs>>? _gattOperationReceived;

    /// <summary>
    /// Event for when a characteristic operation of |type| to the characteristic
    /// respresented by |characteristicId| happened. |data| and |writeType| is
    /// expected to exist when |type| is write.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CharacteristicOperationReceivedEventArgs>> CharacteristicOperationReceived =>
        _characteristicOperationReceived ?? global::System.Threading.Interlocked.CompareExchange(ref _characteristicOperationReceived, EventDescriptor<CdpEventArgs<CharacteristicOperationReceivedEventArgs>>.Create(
            "goog:cdp.BluetoothEmulation.characteristicOperationReceived",
            BluetoothEmulationJsonSerializerContext.Default.CharacteristicOperationReceivedCdpEventArgs), null) ?? _characteristicOperationReceived;
    private static EventDescriptor<CdpEventArgs<CharacteristicOperationReceivedEventArgs>>? _characteristicOperationReceived;

    /// <summary>
    /// Event for when a descriptor operation of |type| to the descriptor
    /// respresented by |descriptorId| happened. |data| is expected to exist when
    /// |type| is write.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DescriptorOperationReceivedEventArgs>> DescriptorOperationReceived =>
        _descriptorOperationReceived ?? global::System.Threading.Interlocked.CompareExchange(ref _descriptorOperationReceived, EventDescriptor<CdpEventArgs<DescriptorOperationReceivedEventArgs>>.Create(
            "goog:cdp.BluetoothEmulation.descriptorOperationReceived",
            BluetoothEmulationJsonSerializerContext.Default.DescriptorOperationReceivedCdpEventArgs), null) ?? _descriptorOperationReceived;
    private static EventDescriptor<CdpEventArgs<DescriptorOperationReceivedEventArgs>>? _descriptorOperationReceived;

}
