#nullable enable
#pragma warning disable CS0612
using global::System.Text.Json.Serialization;
using global::OpenQA.Selenium.BiDi;

namespace Selenium.WebDriver.BiDi.Cdp.SmartCardEmulation;

/// <summary>
/// </summary>
[global::System.Diagnostics.CodeAnalysis.Experimental("BIDICDP001")]
public sealed class SmartCardEmulationDomain(CdpModule cdp) : global::Selenium.WebDriver.BiDi.Cdp.Domain(cdp)
{
    private static SmartCardEmulationJsonSerializerContext JsonContext = SmartCardEmulationJsonSerializerContext.Default;

    /// <summary>
    /// Enables the |SmartCardEmulation| domain.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="EnableCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="EnableResult"/>.
    /// </returns>
    public async Task<EnableResult> EnableAsync(EnableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new EnableCommandParameters();
        return await ExecuteCommandAsync(EnableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<EnableCommandParameters, EnableResult> EnableCommand = new("SmartCardEmulation.enable", JsonContext.EnableCommandParameters, JsonContext.EnableResult);

    /// <summary>
    /// Disables the |SmartCardEmulation| domain.
    /// </summary>
    /// <param name="options">
    /// Optional parameters. See <see cref="DisableCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="DisableResult"/>.
    /// </returns>
    public async Task<DisableResult> DisableAsync(DisableCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new DisableCommandParameters();
        return await ExecuteCommandAsync(DisableCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<DisableCommandParameters, DisableResult> DisableCommand = new("SmartCardEmulation.disable", JsonContext.DisableCommandParameters, JsonContext.DisableResult);

    /// <summary>
    /// Reports the successful result of a |SCardEstablishContext| call.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaa1b8970169fd4883a6dc4a8f43f19b67
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardestablishcontext
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="contextId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportEstablishContextResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportEstablishContextResultResult"/>.
    /// </returns>
    public async Task<ReportEstablishContextResultResult> ReportEstablishContextResultAsync(string requestId, long contextId, ReportEstablishContextResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportEstablishContextResultCommandParameters(RequestId: requestId, ContextId: contextId);
        return await ExecuteCommandAsync(ReportEstablishContextResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportEstablishContextResultCommandParameters, ReportEstablishContextResultResult> ReportEstablishContextResultCommand = new("SmartCardEmulation.reportEstablishContextResult", JsonContext.ReportEstablishContextResultCommandParameters, JsonContext.ReportEstablishContextResultResult);

    /// <summary>
    /// Reports the successful result of a |SCardReleaseContext| call.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga6aabcba7744c5c9419fdd6404f73a934
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardreleasecontext
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportReleaseContextResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportReleaseContextResultResult"/>.
    /// </returns>
    public async Task<ReportReleaseContextResultResult> ReportReleaseContextResultAsync(string requestId, ReportReleaseContextResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportReleaseContextResultCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(ReportReleaseContextResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportReleaseContextResultCommandParameters, ReportReleaseContextResultResult> ReportReleaseContextResultCommand = new("SmartCardEmulation.reportReleaseContextResult", JsonContext.ReportReleaseContextResultCommandParameters, JsonContext.ReportReleaseContextResultResult);

    /// <summary>
    /// Reports the successful result of a |SCardListReaders| call.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga93b07815789b3cf2629d439ecf20f0d9
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardlistreadersa
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="readers">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportListReadersResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportListReadersResultResult"/>.
    /// </returns>
    public async Task<ReportListReadersResultResult> ReportListReadersResultAsync(string requestId, ImmutableArray<string> readers, ReportListReadersResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportListReadersResultCommandParameters(RequestId: requestId, Readers: readers);
        return await ExecuteCommandAsync(ReportListReadersResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportListReadersResultCommandParameters, ReportListReadersResultResult> ReportListReadersResultCommand = new("SmartCardEmulation.reportListReadersResult", JsonContext.ReportListReadersResultCommandParameters, JsonContext.ReportListReadersResultResult);

    /// <summary>
    /// Reports the successful result of a |SCardGetStatusChange| call.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga33247d5d1257d59e55647c3bb717db24
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetstatuschangea
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="readerStates">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportGetStatusChangeResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportGetStatusChangeResultResult"/>.
    /// </returns>
    public async Task<ReportGetStatusChangeResultResult> ReportGetStatusChangeResultAsync(string requestId, ImmutableArray<ReaderStateOut> readerStates, ReportGetStatusChangeResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportGetStatusChangeResultCommandParameters(RequestId: requestId, ReaderStates: readerStates);
        return await ExecuteCommandAsync(ReportGetStatusChangeResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportGetStatusChangeResultCommandParameters, ReportGetStatusChangeResultResult> ReportGetStatusChangeResultCommand = new("SmartCardEmulation.reportGetStatusChangeResult", JsonContext.ReportGetStatusChangeResultCommandParameters, JsonContext.ReportGetStatusChangeResultResult);

    /// <summary>
    /// Reports the result of a |SCardBeginTransaction| call.
    /// On success, this creates a new transaction object.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaddb835dce01a0da1d6ca02d33ee7d861
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardbegintransaction
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="handle">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportBeginTransactionResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportBeginTransactionResultResult"/>.
    /// </returns>
    public async Task<ReportBeginTransactionResultResult> ReportBeginTransactionResultAsync(string requestId, long handle, ReportBeginTransactionResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportBeginTransactionResultCommandParameters(RequestId: requestId, Handle: handle);
        return await ExecuteCommandAsync(ReportBeginTransactionResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportBeginTransactionResultCommandParameters, ReportBeginTransactionResultResult> ReportBeginTransactionResultCommand = new("SmartCardEmulation.reportBeginTransactionResult", JsonContext.ReportBeginTransactionResultCommandParameters, JsonContext.ReportBeginTransactionResultResult);

    /// <summary>
    /// Reports the successful result of a call that returns only a result code.
    /// Used for: |SCardCancel|, |SCardDisconnect|, |SCardSetAttrib|, |SCardEndTransaction|.
    /// 
    /// This maps to:
    /// 1. SCardCancel
    ///    PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacbbc0c6d6c0cbbeb4f4debf6fbeeee6
    ///    Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcancel
    /// 
    /// 2. SCardDisconnect
    ///    PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4be198045c73ec0deb79e66c0ca1738a
    ///    Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scarddisconnect
    /// 
    /// 3. SCardSetAttrib
    ///    PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga060f0038a4ddfd5dd2b8fadf3c3a2e4f
    ///    Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardsetattrib
    /// 
    /// 4. SCardEndTransaction
    ///    PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae8742473b404363e5c587f570d7e2f3b
    ///    Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardendtransaction
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportPlainResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportPlainResultResult"/>.
    /// </returns>
    public async Task<ReportPlainResultResult> ReportPlainResultAsync(string requestId, ReportPlainResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportPlainResultCommandParameters(RequestId: requestId);
        return await ExecuteCommandAsync(ReportPlainResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportPlainResultCommandParameters, ReportPlainResultResult> ReportPlainResultCommand = new("SmartCardEmulation.reportPlainResult", JsonContext.ReportPlainResultCommandParameters, JsonContext.ReportPlainResultResult);

    /// <summary>
    /// Reports the successful result of a |SCardConnect| call.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4e515829752e0a8dbc4d630696a8d6a5
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardconnecta
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>ActiveProtocol</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="requestId">
    /// </param>
    /// <param name="handle">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportConnectResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportConnectResultResult"/>.
    /// </returns>
    public async Task<ReportConnectResultResult> ReportConnectResultAsync(string requestId, long handle, ReportConnectResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportConnectResultCommandParameters(RequestId: requestId, Handle: handle, ActiveProtocol: options?.ActiveProtocol);
        return await ExecuteCommandAsync(ReportConnectResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportConnectResultCommandParameters, ReportConnectResultResult> ReportConnectResultCommand = new("SmartCardEmulation.reportConnectResult", JsonContext.ReportConnectResultCommandParameters, JsonContext.ReportConnectResultResult);

    /// <summary>
    /// Reports the successful result of a call that sends back data on success.
    /// Used for |SCardTransmit|, |SCardControl|, and |SCardGetAttrib|.
    /// 
    /// This maps to:
    /// 1. SCardTransmit
    ///    PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga9a2d77242a271310269065e64633ab99
    ///    Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardtransmit
    /// 
    /// 2. SCardControl
    ///    PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gac3454d4657110fd7f753b2d3d8f4e32f
    ///    Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcontrol
    /// 
    /// 3. SCardGetAttrib
    ///    PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacfec51917255b7a25b94c5104961602
    ///    Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetattrib
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="data">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportDataResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportDataResultResult"/>.
    /// </returns>
    public async Task<ReportDataResultResult> ReportDataResultAsync(string requestId, string data, ReportDataResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportDataResultCommandParameters(RequestId: requestId, Data: data);
        return await ExecuteCommandAsync(ReportDataResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportDataResultCommandParameters, ReportDataResultResult> ReportDataResultCommand = new("SmartCardEmulation.reportDataResult", JsonContext.ReportDataResultCommandParameters, JsonContext.ReportDataResultResult);

    /// <summary>
    /// Reports the successful result of a |SCardStatus| call.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae49c3c894ad7ac12a5b896bde70d0382
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardstatusa
    /// </summary>
    /// <remarks>
    /// Optional parameters (via <paramref name="options"/>):
    /// <list type="bullet">
    /// <item><description><b>Protocol</b></description></item>
    /// </list>
    /// </remarks>
    /// <param name="requestId">
    /// </param>
    /// <param name="readerName">
    /// </param>
    /// <param name="state">
    /// </param>
    /// <param name="atr">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportStatusResultCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportStatusResultResult"/>.
    /// </returns>
    public async Task<ReportStatusResultResult> ReportStatusResultAsync(string requestId, string readerName, ConnectionState state, string atr, ReportStatusResultCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportStatusResultCommandParameters(RequestId: requestId, ReaderName: readerName, State: state, Atr: atr, Protocol: options?.Protocol);
        return await ExecuteCommandAsync(ReportStatusResultCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportStatusResultCommandParameters, ReportStatusResultResult> ReportStatusResultCommand = new("SmartCardEmulation.reportStatusResult", JsonContext.ReportStatusResultCommandParameters, JsonContext.ReportStatusResultResult);

    /// <summary>
    /// Reports an error result for the given request.
    /// </summary>
    /// <param name="requestId">
    /// </param>
    /// <param name="resultCode">
    /// </param>
    /// <param name="options">
    /// Optional parameters. See <see cref="ReportErrorCommandOptions"/>.
    /// </param>
    /// <param name="cancellationToken">
    /// A token to cancel the asynchronous operation.
    /// </param>
    /// <returns>
    /// A task representing the asynchronous operation, containing a <see cref="ReportErrorResult"/>.
    /// </returns>
    public async Task<ReportErrorResult> ReportErrorAsync(string requestId, ResultCode resultCode, ReportErrorCommandOptions? options = default, CancellationToken cancellationToken = default)
    {
        var @params = new ReportErrorCommandParameters(RequestId: requestId, ResultCode: resultCode);
        return await ExecuteCommandAsync(ReportErrorCommand, @params, options, cancellationToken).ConfigureAwait(false);
    }
    private static readonly CdpCommand<ReportErrorCommandParameters, ReportErrorResult> ReportErrorCommand = new("SmartCardEmulation.reportError", JsonContext.ReportErrorCommandParameters, JsonContext.ReportErrorResult);

    /// <summary>
    /// Fired when |SCardEstablishContext| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaa1b8970169fd4883a6dc4a8f43f19b67
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardestablishcontext
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="EstablishContextRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<EstablishContextRequestedEventArgs> EstablishContextRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.EstablishContextRequested);
    /// <summary>
    /// Fired when |SCardReleaseContext| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga6aabcba7744c5c9419fdd6404f73a934
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardreleasecontext
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ReleaseContextRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>ContextId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ReleaseContextRequestedEventArgs> ReleaseContextRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.ReleaseContextRequested);
    /// <summary>
    /// Fired when |SCardListReaders| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga93b07815789b3cf2629d439ecf20f0d9
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardlistreadersa
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ListReadersRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>ContextId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ListReadersRequestedEventArgs> ListReadersRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.ListReadersRequested);
    /// <summary>
    /// Fired when |SCardGetStatusChange| is called. Timeout is specified in milliseconds.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga33247d5d1257d59e55647c3bb717db24
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetstatuschangea
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="GetStatusChangeRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>ReaderStates</b></description></item>
    /// <item><description><b>Timeout</b> - in milliseconds, if absent, it means "infinite"</description></item>
    /// </list>
    /// </remarks>
    public IEventSource<GetStatusChangeRequestedEventArgs> GetStatusChangeRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.GetStatusChangeRequested);
    /// <summary>
    /// Fired when |SCardCancel| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacbbc0c6d6c0cbbeb4f4debf6fbeeee6
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcancel
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="CancelRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>ContextId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<CancelRequestedEventArgs> CancelRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.CancelRequested);
    /// <summary>
    /// Fired when |SCardConnect| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4e515829752e0a8dbc4d630696a8d6a5
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardconnecta
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ConnectRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>ContextId</b></description></item>
    /// <item><description><b>Reader</b></description></item>
    /// <item><description><b>ShareMode</b></description></item>
    /// <item><description><b>PreferredProtocols</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ConnectRequestedEventArgs> ConnectRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.ConnectRequested);
    /// <summary>
    /// Fired when |SCardDisconnect| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4be198045c73ec0deb79e66c0ca1738a
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scarddisconnect
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="DisconnectRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// <item><description><b>Disposition</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<DisconnectRequestedEventArgs> DisconnectRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.DisconnectRequested);
    /// <summary>
    /// Fired when |SCardTransmit| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga9a2d77242a271310269065e64633ab99
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardtransmit
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="TransmitRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// <item><description><b>Data</b></description></item>
    /// <item><description><b>Protocol</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<TransmitRequestedEventArgs> TransmitRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.TransmitRequested);
    /// <summary>
    /// Fired when |SCardControl| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gac3454d4657110fd7f753b2d3d8f4e32f
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcontrol
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="ControlRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// <item><description><b>ControlCode</b></description></item>
    /// <item><description><b>Data</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<ControlRequestedEventArgs> ControlRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.ControlRequested);
    /// <summary>
    /// Fired when |SCardGetAttrib| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacfec51917255b7a25b94c5104961602
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetattrib
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="GetAttribRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// <item><description><b>AttribId</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<GetAttribRequestedEventArgs> GetAttribRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.GetAttribRequested);
    /// <summary>
    /// Fired when |SCardSetAttrib| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga060f0038a4ddfd5dd2b8fadf3c3a2e4f
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardsetattrib
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="SetAttribRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// <item><description><b>AttribId</b></description></item>
    /// <item><description><b>Data</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<SetAttribRequestedEventArgs> SetAttribRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.SetAttribRequested);
    /// <summary>
    /// Fired when |SCardStatus| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae49c3c894ad7ac12a5b896bde70d0382
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardstatusa
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="StatusRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<StatusRequestedEventArgs> StatusRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.StatusRequested);
    /// <summary>
    /// Fired when |SCardBeginTransaction| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaddb835dce01a0da1d6ca02d33ee7d861
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardbegintransaction
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="BeginTransactionRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<BeginTransactionRequestedEventArgs> BeginTransactionRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.BeginTransactionRequested);
    /// <summary>
    /// Fired when |SCardEndTransaction| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae8742473b404363e5c587f570d7e2f3b
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardendtransaction
    /// </summary>
    /// <remarks>
    /// Event args (<see cref="EndTransactionRequestedEventArgs"/>):
    /// <list type="bullet">
    /// <item><description><b>RequestId</b></description></item>
    /// <item><description><b>Handle</b></description></item>
    /// <item><description><b>Disposition</b></description></item>
    /// </list>
    /// </remarks>
    public IEventSource<EndTransactionRequestedEventArgs> EndTransactionRequested => CreateCdpEventSource(SmartCardEmulationDomainEvent.EndTransactionRequested);
}

internal sealed record EnableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.EnableAsync"/>.
/// </summary>
public sealed record EnableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record EnableResult() : EmptyResult;


internal sealed record DisableCommandParameters() : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.DisableAsync"/>.
/// </summary>
public sealed record DisableCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record DisableResult() : EmptyResult;


internal sealed record ReportEstablishContextResultCommandParameters(string RequestId, long ContextId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportEstablishContextResultAsync"/>.
/// </summary>
public sealed record ReportEstablishContextResultCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportEstablishContextResultResult() : EmptyResult;


internal sealed record ReportReleaseContextResultCommandParameters(string RequestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportReleaseContextResultAsync"/>.
/// </summary>
public sealed record ReportReleaseContextResultCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportReleaseContextResultResult() : EmptyResult;


internal sealed record ReportListReadersResultCommandParameters(string RequestId, ImmutableArray<string> Readers) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportListReadersResultAsync"/>.
/// </summary>
public sealed record ReportListReadersResultCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportListReadersResultResult() : EmptyResult;


internal sealed record ReportGetStatusChangeResultCommandParameters(string RequestId, ImmutableArray<ReaderStateOut> ReaderStates) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportGetStatusChangeResultAsync"/>.
/// </summary>
public sealed record ReportGetStatusChangeResultCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportGetStatusChangeResultResult() : EmptyResult;


internal sealed record ReportBeginTransactionResultCommandParameters(string RequestId, long Handle) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportBeginTransactionResultAsync"/>.
/// </summary>
public sealed record ReportBeginTransactionResultCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportBeginTransactionResultResult() : EmptyResult;


internal sealed record ReportPlainResultCommandParameters(string RequestId) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportPlainResultAsync"/>.
/// </summary>
public sealed record ReportPlainResultCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportPlainResultResult() : EmptyResult;


internal sealed record ReportConnectResultCommandParameters(string RequestId, long Handle, Protocol? ActiveProtocol) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportConnectResultAsync"/>.
/// </summary>
public sealed record ReportConnectResultCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public Protocol? ActiveProtocol { get; init; }
}

/// <summary>
/// </summary>
public sealed record ReportConnectResultResult() : EmptyResult;


internal sealed record ReportDataResultCommandParameters(string RequestId, string Data) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportDataResultAsync"/>.
/// </summary>
public sealed record ReportDataResultCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportDataResultResult() : EmptyResult;


internal sealed record ReportStatusResultCommandParameters(string RequestId, string ReaderName, ConnectionState State, string Atr, Protocol? Protocol) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportStatusResultAsync"/>.
/// </summary>
public sealed record ReportStatusResultCommandOptions : CdpCommandOptions
{
    /// <summary>
    /// </summary>
    public Protocol? Protocol { get; init; }
}

/// <summary>
/// </summary>
public sealed record ReportStatusResultResult() : EmptyResult;


internal sealed record ReportErrorCommandParameters(string RequestId, ResultCode ResultCode) : Parameters;

/// <summary>
/// Optional parameters for <see cref="SmartCardEmulationDomain.ReportErrorAsync"/>.
/// </summary>
public sealed record ReportErrorCommandOptions : CdpCommandOptions
{
}

/// <summary>
/// </summary>
public sealed record ReportErrorResult() : EmptyResult;


/// <summary>
/// Fired when |SCardEstablishContext| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaa1b8970169fd4883a6dc4a8f43f19b67
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardestablishcontext
/// </summary>
/// <param name="RequestId">
/// </param>
public sealed record EstablishContextRequestedEventArgs(string RequestId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardReleaseContext| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga6aabcba7744c5c9419fdd6404f73a934
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardreleasecontext
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="ContextId">
/// </param>
public sealed record ReleaseContextRequestedEventArgs(string RequestId, long ContextId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardListReaders| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga93b07815789b3cf2629d439ecf20f0d9
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardlistreadersa
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="ContextId">
/// </param>
public sealed record ListReadersRequestedEventArgs(string RequestId, long ContextId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardGetStatusChange| is called. Timeout is specified in milliseconds.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga33247d5d1257d59e55647c3bb717db24
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetstatuschangea
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="ContextId">
/// </param>
/// <param name="ReaderStates">
/// </param>
/// <param name="Timeout">
/// in milliseconds, if absent, it means "infinite"
/// </param>
public sealed record GetStatusChangeRequestedEventArgs(string RequestId, long ContextId, ImmutableArray<ReaderStateIn> ReaderStates, long? Timeout = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardCancel| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacbbc0c6d6c0cbbeb4f4debf6fbeeee6
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcancel
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="ContextId">
/// </param>
public sealed record CancelRequestedEventArgs(string RequestId, long ContextId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardConnect| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4e515829752e0a8dbc4d630696a8d6a5
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardconnecta
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="ContextId">
/// </param>
/// <param name="Reader">
/// </param>
/// <param name="ShareMode">
/// </param>
/// <param name="PreferredProtocols">
/// </param>
public sealed record ConnectRequestedEventArgs(string RequestId, long ContextId, string Reader, ShareMode ShareMode, ProtocolSet PreferredProtocols) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardDisconnect| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4be198045c73ec0deb79e66c0ca1738a
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scarddisconnect
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
/// <param name="Disposition">
/// </param>
public sealed record DisconnectRequestedEventArgs(string RequestId, long Handle, Disposition Disposition) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardTransmit| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga9a2d77242a271310269065e64633ab99
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardtransmit
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
/// <param name="Data">
/// </param>
/// <param name="Protocol">
/// </param>
public sealed record TransmitRequestedEventArgs(string RequestId, long Handle, string Data, Protocol? Protocol = null) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardControl| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gac3454d4657110fd7f753b2d3d8f4e32f
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcontrol
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
/// <param name="ControlCode">
/// </param>
/// <param name="Data">
/// </param>
public sealed record ControlRequestedEventArgs(string RequestId, long Handle, long ControlCode, string Data) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardGetAttrib| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacfec51917255b7a25b94c5104961602
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetattrib
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
/// <param name="AttribId">
/// </param>
public sealed record GetAttribRequestedEventArgs(string RequestId, long Handle, long AttribId) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardSetAttrib| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga060f0038a4ddfd5dd2b8fadf3c3a2e4f
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardsetattrib
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
/// <param name="AttribId">
/// </param>
/// <param name="Data">
/// </param>
public sealed record SetAttribRequestedEventArgs(string RequestId, long Handle, long AttribId, string Data) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardStatus| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae49c3c894ad7ac12a5b896bde70d0382
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardstatusa
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
public sealed record StatusRequestedEventArgs(string RequestId, long Handle) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardBeginTransaction| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaddb835dce01a0da1d6ca02d33ee7d861
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardbegintransaction
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
public sealed record BeginTransactionRequestedEventArgs(string RequestId, long Handle) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Fired when |SCardEndTransaction| is called.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae8742473b404363e5c587f570d7e2f3b
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardendtransaction
/// </summary>
/// <param name="RequestId">
/// </param>
/// <param name="Handle">
/// </param>
/// <param name="Disposition">
/// </param>
public sealed record EndTransactionRequestedEventArgs(string RequestId, long Handle, Disposition Disposition) : OpenQA.Selenium.BiDi.EventArgs;

/// <summary>
/// Indicates the PC/SC error code.
/// 
/// This maps to:
/// PC/SC Lite: https://pcsclite.apdu.fr/api/group__ErrorCodes.html
/// Microsoft: https://learn.microsoft.com/en-us/windows/win32/secauthn/authentication-return-values
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ResultCode>))]
public enum ResultCode
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("success")]
    Success,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("removed-card")]
    RemovedCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reset-card")]
    ResetCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unpowered-card")]
    UnpoweredCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unresponsive-card")]
    UnresponsiveCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unsupported-card")]
    UnsupportedCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reader-unavailable")]
    ReaderUnavailable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("sharing-violation")]
    SharingViolation,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("not-transacted")]
    NotTransacted,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("no-smartcard")]
    NoSmartcard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("proto-mismatch")]
    ProtoMismatch,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("system-cancelled")]
    SystemCancelled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("not-ready")]
    NotReady,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("cancelled")]
    Cancelled,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("insufficient-buffer")]
    InsufficientBuffer,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("invalid-handle")]
    InvalidHandle,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("invalid-parameter")]
    InvalidParameter,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("invalid-value")]
    InvalidValue,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("no-memory")]
    NoMemory,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("timeout")]
    Timeout,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unknown-reader")]
    UnknownReader,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unsupported-feature")]
    UnsupportedFeature,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("no-readers-available")]
    NoReadersAvailable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("service-stopped")]
    ServiceStopped,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("no-service")]
    NoService,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("comm-error")]
    CommError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("internal-error")]
    InternalError,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("server-too-busy")]
    ServerTooBusy,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unexpected")]
    Unexpected,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shutdown")]
    Shutdown,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unknown-card")]
    UnknownCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unknown")]
    Unknown,
}

/// <summary>
/// Maps to the |SCARD_SHARE_*| values.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ShareMode>))]
public enum ShareMode
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("shared")]
    Shared,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("exclusive")]
    Exclusive,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("direct")]
    Direct,
}

/// <summary>
/// Indicates what the reader should do with the card.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<Disposition>))]
public enum Disposition
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("leave-card")]
    LeaveCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("reset-card")]
    ResetCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("unpower-card")]
    UnpowerCard,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("eject-card")]
    EjectCard,
}

/// <summary>
/// Maps to |SCARD_*| connection state values.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<ConnectionState>))]
public enum ConnectionState
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("absent")]
    Absent,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("present")]
    Present,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("swallowed")]
    Swallowed,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("powered")]
    Powered,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("negotiable")]
    Negotiable,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("specific")]
    Specific,
}

/// <summary>
/// Maps to the |SCARD_STATE_*| flags.
/// </summary>
public sealed record ReaderStateFlags()
{
    /// <summary>
    /// </summary>
    public bool? Unaware { get; init; }

    /// <summary>
    /// </summary>
    public bool? Ignore { get; init; }

    /// <summary>
    /// </summary>
    public bool? Changed { get; init; }

    /// <summary>
    /// </summary>
    public bool? Unknown { get; init; }

    /// <summary>
    /// </summary>
    public bool? Unavailable { get; init; }

    /// <summary>
    /// </summary>
    public bool? Empty { get; init; }

    /// <summary>
    /// </summary>
    public bool? Present { get; init; }

    /// <summary>
    /// </summary>
    public bool? Exclusive { get; init; }

    /// <summary>
    /// </summary>
    public bool? Inuse { get; init; }

    /// <summary>
    /// </summary>
    public bool? Mute { get; init; }

    /// <summary>
    /// </summary>
    public bool? Unpowered { get; init; }
}

/// <summary>
/// Maps to the |SCARD_PROTOCOL_*| flags.
/// </summary>
public sealed record ProtocolSet()
{
    /// <summary>
    /// </summary>
    public bool? T0 { get; init; }

    /// <summary>
    /// </summary>
    public bool? T1 { get; init; }

    /// <summary>
    /// </summary>
    public bool? Raw { get; init; }
}

/// <summary>
/// Maps to the |SCARD_PROTOCOL_*| values.
/// </summary>
[global::System.Text.Json.Serialization.JsonConverter(typeof(Json.JsonStringEnumConverter<Protocol>))]
public enum Protocol
{
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("t0")]
    T0,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("t1")]
    T1,
    /// <summary>
    /// </summary>
    [global::System.Text.Json.Serialization.JsonStringEnumMemberName("raw")]
    Raw,
}

/// <summary>
/// </summary>
/// <param name="Reader">
/// </param>
/// <param name="CurrentState">
/// </param>
/// <param name="CurrentInsertionCount">
/// </param>
public sealed record ReaderStateIn(string Reader, ReaderStateFlags CurrentState, long CurrentInsertionCount)
{
}

/// <summary>
/// </summary>
/// <param name="Reader">
/// </param>
/// <param name="EventState">
/// </param>
/// <param name="EventCount">
/// </param>
/// <param name="Atr">
/// </param>
public sealed record ReaderStateOut(string Reader, ReaderStateFlags EventState, long EventCount, string Atr)
{
}

[JsonSerializable(typeof(EnableCommandParameters), TypeInfoPropertyName = "EnableCommandParameters")]
[JsonSerializable(typeof(EnableResult), TypeInfoPropertyName = "EnableResult")]
[JsonSerializable(typeof(DisableCommandParameters), TypeInfoPropertyName = "DisableCommandParameters")]
[JsonSerializable(typeof(DisableResult), TypeInfoPropertyName = "DisableResult")]
[JsonSerializable(typeof(ReportEstablishContextResultCommandParameters), TypeInfoPropertyName = "ReportEstablishContextResultCommandParameters")]
[JsonSerializable(typeof(ReportEstablishContextResultResult), TypeInfoPropertyName = "ReportEstablishContextResultResult")]
[JsonSerializable(typeof(ReportReleaseContextResultCommandParameters), TypeInfoPropertyName = "ReportReleaseContextResultCommandParameters")]
[JsonSerializable(typeof(ReportReleaseContextResultResult), TypeInfoPropertyName = "ReportReleaseContextResultResult")]
[JsonSerializable(typeof(ReportListReadersResultCommandParameters), TypeInfoPropertyName = "ReportListReadersResultCommandParameters")]
[JsonSerializable(typeof(ReportListReadersResultResult), TypeInfoPropertyName = "ReportListReadersResultResult")]
[JsonSerializable(typeof(ReportGetStatusChangeResultCommandParameters), TypeInfoPropertyName = "ReportGetStatusChangeResultCommandParameters")]
[JsonSerializable(typeof(ReportGetStatusChangeResultResult), TypeInfoPropertyName = "ReportGetStatusChangeResultResult")]
[JsonSerializable(typeof(ReportBeginTransactionResultCommandParameters), TypeInfoPropertyName = "ReportBeginTransactionResultCommandParameters")]
[JsonSerializable(typeof(ReportBeginTransactionResultResult), TypeInfoPropertyName = "ReportBeginTransactionResultResult")]
[JsonSerializable(typeof(ReportPlainResultCommandParameters), TypeInfoPropertyName = "ReportPlainResultCommandParameters")]
[JsonSerializable(typeof(ReportPlainResultResult), TypeInfoPropertyName = "ReportPlainResultResult")]
[JsonSerializable(typeof(ReportConnectResultCommandParameters), TypeInfoPropertyName = "ReportConnectResultCommandParameters")]
[JsonSerializable(typeof(ReportConnectResultResult), TypeInfoPropertyName = "ReportConnectResultResult")]
[JsonSerializable(typeof(ReportDataResultCommandParameters), TypeInfoPropertyName = "ReportDataResultCommandParameters")]
[JsonSerializable(typeof(ReportDataResultResult), TypeInfoPropertyName = "ReportDataResultResult")]
[JsonSerializable(typeof(ReportStatusResultCommandParameters), TypeInfoPropertyName = "ReportStatusResultCommandParameters")]
[JsonSerializable(typeof(ReportStatusResultResult), TypeInfoPropertyName = "ReportStatusResultResult")]
[JsonSerializable(typeof(ReportErrorCommandParameters), TypeInfoPropertyName = "ReportErrorCommandParameters")]
[JsonSerializable(typeof(ReportErrorResult), TypeInfoPropertyName = "ReportErrorResult")]
[JsonSerializable(typeof(CdpEventArgs<EstablishContextRequestedEventArgs>), TypeInfoPropertyName = "EstablishContextRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ReleaseContextRequestedEventArgs>), TypeInfoPropertyName = "ReleaseContextRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ListReadersRequestedEventArgs>), TypeInfoPropertyName = "ListReadersRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<GetStatusChangeRequestedEventArgs>), TypeInfoPropertyName = "GetStatusChangeRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<CancelRequestedEventArgs>), TypeInfoPropertyName = "CancelRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ConnectRequestedEventArgs>), TypeInfoPropertyName = "ConnectRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<DisconnectRequestedEventArgs>), TypeInfoPropertyName = "DisconnectRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<TransmitRequestedEventArgs>), TypeInfoPropertyName = "TransmitRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<ControlRequestedEventArgs>), TypeInfoPropertyName = "ControlRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<GetAttribRequestedEventArgs>), TypeInfoPropertyName = "GetAttribRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<SetAttribRequestedEventArgs>), TypeInfoPropertyName = "SetAttribRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<StatusRequestedEventArgs>), TypeInfoPropertyName = "StatusRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<BeginTransactionRequestedEventArgs>), TypeInfoPropertyName = "BeginTransactionRequestedCdpEventArgs")]
[JsonSerializable(typeof(CdpEventArgs<EndTransactionRequestedEventArgs>), TypeInfoPropertyName = "EndTransactionRequestedCdpEventArgs")]
[JsonSerializable(typeof(ResultCode), TypeInfoPropertyName = "SmartCardEmulationResultCode")]
[JsonSerializable(typeof(ShareMode), TypeInfoPropertyName = "SmartCardEmulationShareMode")]
[JsonSerializable(typeof(Disposition), TypeInfoPropertyName = "SmartCardEmulationDisposition")]
[JsonSerializable(typeof(ConnectionState), TypeInfoPropertyName = "SmartCardEmulationConnectionState")]
[JsonSerializable(typeof(ReaderStateFlags), TypeInfoPropertyName = "SmartCardEmulationReaderStateFlags")]
[JsonSerializable(typeof(ProtocolSet), TypeInfoPropertyName = "SmartCardEmulationProtocolSet")]
[JsonSerializable(typeof(Protocol), TypeInfoPropertyName = "SmartCardEmulationProtocol")]
[JsonSerializable(typeof(ReaderStateIn), TypeInfoPropertyName = "SmartCardEmulationReaderStateIn")]
[JsonSerializable(typeof(ReaderStateOut), TypeInfoPropertyName = "SmartCardEmulationReaderStateOut")]
[JsonSerializable(typeof(ImmutableArray<ReaderStateOut>), TypeInfoPropertyName = "ImmutableArraySmartCardEmulationReaderStateOut")]
[JsonSerializable(typeof(ImmutableArray<ReaderStateIn>), TypeInfoPropertyName = "ImmutableArraySmartCardEmulationReaderStateIn")]
[JsonSourceGenerationOptions(
PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
partial class SmartCardEmulationJsonSerializerContext : JsonSerializerContext;

/// <summary>
/// Provides static event descriptors for the <see cref="SmartCardEmulationDomain"/>.
/// </summary>
public static class SmartCardEmulationDomainEvent
{
    /// <summary>
    /// Fired when |SCardEstablishContext| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaa1b8970169fd4883a6dc4a8f43f19b67
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardestablishcontext
    /// </summary>
    public static EventDescriptor<CdpEventArgs<EstablishContextRequestedEventArgs>> EstablishContextRequested { get; } =
        EventDescriptor<CdpEventArgs<EstablishContextRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.establishContextRequested",
            SmartCardEmulationJsonSerializerContext.Default.EstablishContextRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardReleaseContext| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga6aabcba7744c5c9419fdd6404f73a934
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardreleasecontext
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ReleaseContextRequestedEventArgs>> ReleaseContextRequested { get; } =
        EventDescriptor<CdpEventArgs<ReleaseContextRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.releaseContextRequested",
            SmartCardEmulationJsonSerializerContext.Default.ReleaseContextRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardListReaders| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga93b07815789b3cf2629d439ecf20f0d9
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardlistreadersa
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ListReadersRequestedEventArgs>> ListReadersRequested { get; } =
        EventDescriptor<CdpEventArgs<ListReadersRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.listReadersRequested",
            SmartCardEmulationJsonSerializerContext.Default.ListReadersRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardGetStatusChange| is called. Timeout is specified in milliseconds.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga33247d5d1257d59e55647c3bb717db24
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetstatuschangea
    /// </summary>
    public static EventDescriptor<CdpEventArgs<GetStatusChangeRequestedEventArgs>> GetStatusChangeRequested { get; } =
        EventDescriptor<CdpEventArgs<GetStatusChangeRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.getStatusChangeRequested",
            SmartCardEmulationJsonSerializerContext.Default.GetStatusChangeRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardCancel| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacbbc0c6d6c0cbbeb4f4debf6fbeeee6
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcancel
    /// </summary>
    public static EventDescriptor<CdpEventArgs<CancelRequestedEventArgs>> CancelRequested { get; } =
        EventDescriptor<CdpEventArgs<CancelRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.cancelRequested",
            SmartCardEmulationJsonSerializerContext.Default.CancelRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardConnect| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4e515829752e0a8dbc4d630696a8d6a5
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardconnecta
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ConnectRequestedEventArgs>> ConnectRequested { get; } =
        EventDescriptor<CdpEventArgs<ConnectRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.connectRequested",
            SmartCardEmulationJsonSerializerContext.Default.ConnectRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardDisconnect| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga4be198045c73ec0deb79e66c0ca1738a
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scarddisconnect
    /// </summary>
    public static EventDescriptor<CdpEventArgs<DisconnectRequestedEventArgs>> DisconnectRequested { get; } =
        EventDescriptor<CdpEventArgs<DisconnectRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.disconnectRequested",
            SmartCardEmulationJsonSerializerContext.Default.DisconnectRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardTransmit| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga9a2d77242a271310269065e64633ab99
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardtransmit
    /// </summary>
    public static EventDescriptor<CdpEventArgs<TransmitRequestedEventArgs>> TransmitRequested { get; } =
        EventDescriptor<CdpEventArgs<TransmitRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.transmitRequested",
            SmartCardEmulationJsonSerializerContext.Default.TransmitRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardControl| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gac3454d4657110fd7f753b2d3d8f4e32f
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardcontrol
    /// </summary>
    public static EventDescriptor<CdpEventArgs<ControlRequestedEventArgs>> ControlRequested { get; } =
        EventDescriptor<CdpEventArgs<ControlRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.controlRequested",
            SmartCardEmulationJsonSerializerContext.Default.ControlRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardGetAttrib| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaacfec51917255b7a25b94c5104961602
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardgetattrib
    /// </summary>
    public static EventDescriptor<CdpEventArgs<GetAttribRequestedEventArgs>> GetAttribRequested { get; } =
        EventDescriptor<CdpEventArgs<GetAttribRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.getAttribRequested",
            SmartCardEmulationJsonSerializerContext.Default.GetAttribRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardSetAttrib| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#ga060f0038a4ddfd5dd2b8fadf3c3a2e4f
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardsetattrib
    /// </summary>
    public static EventDescriptor<CdpEventArgs<SetAttribRequestedEventArgs>> SetAttribRequested { get; } =
        EventDescriptor<CdpEventArgs<SetAttribRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.setAttribRequested",
            SmartCardEmulationJsonSerializerContext.Default.SetAttribRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardStatus| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae49c3c894ad7ac12a5b896bde70d0382
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardstatusa
    /// </summary>
    public static EventDescriptor<CdpEventArgs<StatusRequestedEventArgs>> StatusRequested { get; } =
        EventDescriptor<CdpEventArgs<StatusRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.statusRequested",
            SmartCardEmulationJsonSerializerContext.Default.StatusRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardBeginTransaction| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gaddb835dce01a0da1d6ca02d33ee7d861
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardbegintransaction
    /// </summary>
    public static EventDescriptor<CdpEventArgs<BeginTransactionRequestedEventArgs>> BeginTransactionRequested { get; } =
        EventDescriptor<CdpEventArgs<BeginTransactionRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.beginTransactionRequested",
            SmartCardEmulationJsonSerializerContext.Default.BeginTransactionRequestedCdpEventArgs);

    /// <summary>
    /// Fired when |SCardEndTransaction| is called.
    /// 
    /// This maps to:
    /// PC/SC Lite: https://pcsclite.apdu.fr/api/group__API.html#gae8742473b404363e5c587f570d7e2f3b
    /// Microsoft: https://learn.microsoft.com/en-us/windows/win32/api/winscard/nf-winscard-scardendtransaction
    /// </summary>
    public static EventDescriptor<CdpEventArgs<EndTransactionRequestedEventArgs>> EndTransactionRequested { get; } =
        EventDescriptor<CdpEventArgs<EndTransactionRequestedEventArgs>>.Create(
            "goog:cdp.SmartCardEmulation.endTransactionRequested",
            SmartCardEmulationJsonSerializerContext.Default.EndTransactionRequestedCdpEventArgs);

}
