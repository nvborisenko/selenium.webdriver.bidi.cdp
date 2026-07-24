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
public sealed class BluetoothEmulationDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static BluetoothEmulationJsonSerializerContext JsonContext = BluetoothEmulationJsonSerializerContext.Default;

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
    public async Task<EnableResult> EnableAsync(CentralState state, bool leSupported, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters(State: state, LeSupported: leSupported);
        return await ExecuteCommandAsync(EnableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("BluetoothEmulation.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

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
    public async Task<SetSimulatedCentralStateResult> SetSimulatedCentralStateAsync(CentralState state, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SetSimulatedCentralStateCommandParameters(State: state);
        return await ExecuteCommandAsync(SetSimulatedCentralStateCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SetSimulatedCentralStateCommandParameters, SetSimulatedCentralStateResult> SetSimulatedCentralStateCommand = new("BluetoothEmulation.setSimulatedCentralState", JsonContext.SetSimulatedCentralStateCommandParameters, JsonContext.SetSimulatedCentralStateResult);

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
    public async Task<DisableResult> DisableAsync(string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("BluetoothEmulation.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

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
    public async Task<SimulatePreconnectedPeripheralResult> SimulatePreconnectedPeripheralAsync(string address, string name, ImmutableArray<ManufacturerData> manufacturerData, ImmutableArray<string> knownServiceUuids, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SimulatePreconnectedPeripheralCommandParameters(Address: address, Name: name, ManufacturerData: manufacturerData, KnownServiceUuids: knownServiceUuids);
        return await ExecuteCommandAsync(SimulatePreconnectedPeripheralCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SimulatePreconnectedPeripheralCommandParameters, SimulatePreconnectedPeripheralResult> SimulatePreconnectedPeripheralCommand = new("BluetoothEmulation.simulatePreconnectedPeripheral", JsonContext.SimulatePreconnectedPeripheralCommandParameters, JsonContext.SimulatePreconnectedPeripheralResult);

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
    public async Task<SimulateAdvertisementResult> SimulateAdvertisementAsync(ScanEntry entry, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateAdvertisementCommandParameters(Entry: entry);
        return await ExecuteCommandAsync(SimulateAdvertisementCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SimulateAdvertisementCommandParameters, SimulateAdvertisementResult> SimulateAdvertisementCommand = new("BluetoothEmulation.simulateAdvertisement", JsonContext.SimulateAdvertisementCommandParameters, JsonContext.SimulateAdvertisementResult);

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
    public async Task<SimulateGATTOperationResponseResult> SimulateGATTOperationResponseAsync(string address, GATTOperationType type, long code, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateGATTOperationResponseCommandParameters(Address: address, Type: type, Code: code);
        return await ExecuteCommandAsync(SimulateGATTOperationResponseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SimulateGATTOperationResponseCommandParameters, SimulateGATTOperationResponseResult> SimulateGATTOperationResponseCommand = new("BluetoothEmulation.simulateGATTOperationResponse", JsonContext.SimulateGATTOperationResponseCommandParameters, JsonContext.SimulateGATTOperationResponseResult);

    /// <summary>
    /// Simulates the response from the characteristic with |characteristicId| for a
    /// characteristic operation of |type|. The |code| value follows the Error
    /// Codes from Bluetooth Core Specification Vol 3 Part F 3.4.1.1 Error Response.
    /// The |data| is expected to exist when simulating a successful read operation
    /// response.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Data</b></description></item>
    /// </list>
    /// </remarks>
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
    public async Task<SimulateCharacteristicOperationResponseResult> SimulateCharacteristicOperationResponseAsync(string characteristicId, CharacteristicOperationType type, long code, string? data = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateCharacteristicOperationResponseCommandParameters(CharacteristicId: characteristicId, Type: type, Code: code, Data: data);
        return await ExecuteCommandAsync(SimulateCharacteristicOperationResponseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SimulateCharacteristicOperationResponseCommandParameters, SimulateCharacteristicOperationResponseResult> SimulateCharacteristicOperationResponseCommand = new("BluetoothEmulation.simulateCharacteristicOperationResponse", JsonContext.SimulateCharacteristicOperationResponseCommandParameters, JsonContext.SimulateCharacteristicOperationResponseResult);

    /// <summary>
    /// Simulates the response from the descriptor with |descriptorId| for a
    /// descriptor operation of |type|. The |code| value follows the Error
    /// Codes from Bluetooth Core Specification Vol 3 Part F 3.4.1.1 Error Response.
    /// The |data| is expected to exist when simulating a successful read operation
    /// response.
    /// </summary>
    /// <remarks>
    /// Optional parameters:
    /// <list type="bullet">
    /// <item><description><b>Data</b></description></item>
    /// </list>
    /// </remarks>
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
    public async Task<SimulateDescriptorOperationResponseResult> SimulateDescriptorOperationResponseAsync(string descriptorId, DescriptorOperationType type, long code, string? data = default, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateDescriptorOperationResponseCommandParameters(DescriptorId: descriptorId, Type: type, Code: code, Data: data);
        return await ExecuteCommandAsync(SimulateDescriptorOperationResponseCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SimulateDescriptorOperationResponseCommandParameters, SimulateDescriptorOperationResponseResult> SimulateDescriptorOperationResponseCommand = new("BluetoothEmulation.simulateDescriptorOperationResponse", JsonContext.SimulateDescriptorOperationResponseCommandParameters, JsonContext.SimulateDescriptorOperationResponseResult);

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
    public async Task<AddServiceResult> AddServiceAsync(string address, string serviceUuid, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddServiceCommandParameters(Address: address, ServiceUuid: serviceUuid);
        return await ExecuteCommandAsync(AddServiceCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddServiceCommandParameters, AddServiceResult> AddServiceCommand = new("BluetoothEmulation.addService", JsonContext.AddServiceCommandParameters, JsonContext.AddServiceResult);

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
    public async Task<RemoveServiceResult> RemoveServiceAsync(string serviceId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveServiceCommandParameters(ServiceId: serviceId);
        return await ExecuteCommandAsync(RemoveServiceCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveServiceCommandParameters, RemoveServiceResult> RemoveServiceCommand = new("BluetoothEmulation.removeService", JsonContext.RemoveServiceCommandParameters, JsonContext.RemoveServiceResult);

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
    public async Task<AddCharacteristicResult> AddCharacteristicAsync(string serviceId, string characteristicUuid, CharacteristicProperties properties, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddCharacteristicCommandParameters(ServiceId: serviceId, CharacteristicUuid: characteristicUuid, Properties: properties);
        return await ExecuteCommandAsync(AddCharacteristicCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddCharacteristicCommandParameters, AddCharacteristicResult> AddCharacteristicCommand = new("BluetoothEmulation.addCharacteristic", JsonContext.AddCharacteristicCommandParameters, JsonContext.AddCharacteristicResult);

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
    public async Task<RemoveCharacteristicResult> RemoveCharacteristicAsync(string characteristicId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveCharacteristicCommandParameters(CharacteristicId: characteristicId);
        return await ExecuteCommandAsync(RemoveCharacteristicCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveCharacteristicCommandParameters, RemoveCharacteristicResult> RemoveCharacteristicCommand = new("BluetoothEmulation.removeCharacteristic", JsonContext.RemoveCharacteristicCommandParameters, JsonContext.RemoveCharacteristicResult);

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
    public async Task<AddDescriptorResult> AddDescriptorAsync(string characteristicId, string descriptorUuid, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new AddDescriptorCommandParameters(CharacteristicId: characteristicId, DescriptorUuid: descriptorUuid);
        return await ExecuteCommandAsync(AddDescriptorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<AddDescriptorCommandParameters, AddDescriptorResult> AddDescriptorCommand = new("BluetoothEmulation.addDescriptor", JsonContext.AddDescriptorCommandParameters, JsonContext.AddDescriptorResult);

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
    public async Task<RemoveDescriptorResult> RemoveDescriptorAsync(string descriptorId, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new RemoveDescriptorCommandParameters(DescriptorId: descriptorId);
        return await ExecuteCommandAsync(RemoveDescriptorCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<RemoveDescriptorCommandParameters, RemoveDescriptorResult> RemoveDescriptorCommand = new("BluetoothEmulation.removeDescriptor", JsonContext.RemoveDescriptorCommandParameters, JsonContext.RemoveDescriptorResult);

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
    public async Task<SimulateGATTDisconnectionResult> SimulateGATTDisconnectionAsync(string address, string? session = default, CancellationToken cancellationToken = default)
    {
        var @params = new SimulateGATTDisconnectionCommandParameters(Address: address);
        return await ExecuteCommandAsync(SimulateGATTDisconnectionCommand, @params, session, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<SimulateGATTDisconnectionCommandParameters, SimulateGATTDisconnectionResult> SimulateGATTDisconnectionCommand = new("BluetoothEmulation.simulateGATTDisconnection", JsonContext.SimulateGATTDisconnectionCommandParameters, JsonContext.SimulateGATTDisconnectionResult);

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
    public IEventSource<GattOperationReceivedEventArgs> GattOperationReceived => CreateCdpEventSource(BluetoothEmulationDomainEvent.GattOperationReceived);
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
    public IEventSource<CharacteristicOperationReceivedEventArgs> CharacteristicOperationReceived => CreateCdpEventSource(BluetoothEmulationDomainEvent.CharacteristicOperationReceived);
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
    public IEventSource<DescriptorOperationReceivedEventArgs> DescriptorOperationReceived => CreateCdpEventSource(BluetoothEmulationDomainEvent.DescriptorOperationReceived);
}

internal sealed record EnableCommandParameters(CentralState State, bool LeSupported) : Parameters;

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record SetSimulatedCentralStateCommandParameters(CentralState State) : Parameters;

/// <summary>
/// </summary>
public sealed record SetSimulatedCentralStateResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record SimulatePreconnectedPeripheralCommandParameters(string Address, string Name, ImmutableArray<ManufacturerData> ManufacturerData, ImmutableArray<string> KnownServiceUuids) : Parameters;

/// <summary>
/// </summary>
public sealed record SimulatePreconnectedPeripheralResult() : EmptyResult;


internal sealed record SimulateAdvertisementCommandParameters(ScanEntry Entry) : Parameters;

/// <summary>
/// </summary>
public sealed record SimulateAdvertisementResult() : EmptyResult;


internal sealed record SimulateGATTOperationResponseCommandParameters(string Address, GATTOperationType Type, long Code) : Parameters;

/// <summary>
/// </summary>
public sealed record SimulateGATTOperationResponseResult() : EmptyResult;


internal sealed record SimulateCharacteristicOperationResponseCommandParameters(string CharacteristicId, CharacteristicOperationType Type, long Code, string? Data) : Parameters;

/// <summary>
/// </summary>
public sealed record SimulateCharacteristicOperationResponseResult() : EmptyResult;


internal sealed record SimulateDescriptorOperationResponseCommandParameters(string DescriptorId, DescriptorOperationType Type, long Code, string? Data) : Parameters;

/// <summary>
/// </summary>
public sealed record SimulateDescriptorOperationResponseResult() : EmptyResult;


internal sealed record AddServiceCommandParameters(string Address, string ServiceUuid) : Parameters;

/// <summary>
/// </summary>
/// <param name="ServiceId">
/// An identifier that uniquely represents this service.
/// </param>
public sealed record AddServiceResult(string ServiceId) : EmptyResult;


internal sealed record RemoveServiceCommandParameters(string ServiceId) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveServiceResult() : EmptyResult;


internal sealed record AddCharacteristicCommandParameters(string ServiceId, string CharacteristicUuid, CharacteristicProperties Properties) : Parameters;

/// <summary>
/// </summary>
/// <param name="CharacteristicId">
/// An identifier that uniquely represents this characteristic.
/// </param>
public sealed record AddCharacteristicResult(string CharacteristicId) : EmptyResult;


internal sealed record RemoveCharacteristicCommandParameters(string CharacteristicId) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveCharacteristicResult() : EmptyResult;


internal sealed record AddDescriptorCommandParameters(string CharacteristicId, string DescriptorUuid) : Parameters;

/// <summary>
/// </summary>
/// <param name="DescriptorId">
/// An identifier that uniquely represents this descriptor.
/// </param>
public sealed record AddDescriptorResult(string DescriptorId) : EmptyResult;


internal sealed record RemoveDescriptorCommandParameters(string DescriptorId) : Parameters;

/// <summary>
/// </summary>
public sealed record RemoveDescriptorResult() : EmptyResult;


internal sealed record SimulateGATTDisconnectionCommandParameters(string Address) : Parameters;

/// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("absent")]
    Absent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("powered-off")]
    PoweredOff,
    /// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("connection")]
    Connection,
    /// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write-default-deprecated")]
    WriteDefaultDeprecated,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write-with-response")]
    WriteWithResponse,
    /// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("read")]
    Read,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("write")]
    Write,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("subscribe-to-notifications")]
    SubscribeToNotifications,
    /// <summary>
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
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("read")]
    Read,
    /// <summary>
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
/// Provides static event descriptors for the <see cref="BluetoothEmulationDomain"/>.
/// </summary>
public static class BluetoothEmulationDomainEvent
{
    /// <summary>
    /// Event for when a GATT operation of |type| to the peripheral with |address|
    /// happened.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<GattOperationReceivedEventArgs>> GattOperationReceived { get; } =
        EventDescriptor<CdpEventArgs<GattOperationReceivedEventArgs>>.Create(
            "goog:cdp.BluetoothEmulation.gattOperationReceived",
            BluetoothEmulationJsonSerializerContext.Default.GattOperationReceivedCdpEventArgs);

    /// <summary>
    /// Event for when a characteristic operation of |type| to the characteristic
    /// respresented by |characteristicId| happened. |data| and |writeType| is
    /// expected to exist when |type| is write.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CharacteristicOperationReceivedEventArgs>> CharacteristicOperationReceived { get; } =
        EventDescriptor<CdpEventArgs<CharacteristicOperationReceivedEventArgs>>.Create(
            "goog:cdp.BluetoothEmulation.characteristicOperationReceived",
            BluetoothEmulationJsonSerializerContext.Default.CharacteristicOperationReceivedCdpEventArgs);

    /// <summary>
    /// Event for when a descriptor operation of |type| to the descriptor
    /// respresented by |descriptorId| happened. |data| is expected to exist when
    /// |type| is write.
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DescriptorOperationReceivedEventArgs>> DescriptorOperationReceived { get; } =
        EventDescriptor<CdpEventArgs<DescriptorOperationReceivedEventArgs>>.Create(
            "goog:cdp.BluetoothEmulation.descriptorOperationReceived",
            BluetoothEmulationJsonSerializerContext.Default.DescriptorOperationReceivedCdpEventArgs);

}
